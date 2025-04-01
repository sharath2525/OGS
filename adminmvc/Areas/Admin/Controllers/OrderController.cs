using adminmvc.Models;
using adminmvc.Repository.IRepository;
using adminmvc.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace adminmvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class OrderController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        [BindProperty]
        public OrderVM OrderVM { get; set;  }
        public OrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index(string SearchString, string SortBy)
        {
            IEnumerable<Order> objOrder;

            if (User.IsInRole("Admin"))
            {
                objOrder = _unitOfWork.Order.GetAll(includeProperties: "ApplicationUser").ToList();
            }
            else
            {
                var claimsIdentity = (ClaimsIdentity)User.Identity;
                var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

                objOrder = _unitOfWork.Order.GetAll(u => u.ApplicationUserId == userId, includeProperties: "ApplicationUser").ToList();
            }

            if (!String.IsNullOrEmpty(SearchString))
            {
                objOrder = objOrder.Where(p => p.Name.ToLower().Contains(SearchString.ToLower())).ToList();
            }
            else if(SortBy == "Cancelled")
            {
                objOrder = objOrder.Where(p => p.OrderStatus == SortBy).ToList();
            }
            else if (SortBy == "Shipped")
            {
                objOrder = objOrder.Where(p => p.OrderStatus == SortBy).ToList();
            }
            else if (SortBy == "Approved")
            {
                objOrder = objOrder.Where(p => p.OrderStatus == SortBy).ToList();
            }
            else if (SortBy == "Failed")
            {
                objOrder = objOrder.Where(p => p.OrderStatus == SortBy).ToList();
            }
            else if (SortBy == "All")
            {
                return View(objOrder);
            }
            return View(objOrder);
        }

        public IActionResult Details(int id)
        {
            OrderVM = new()
            {
                Order = _unitOfWork.Order.Get(u => u.OrderId == id, includeProperties: "ApplicationUser"),
                OrderDetail = _unitOfWork.OrderDetail.GetAll(u => u.OrderId == id, includeProperties: "Product")
            };
            return View(OrderVM);
        }


        [HttpPost]
        [Authorize(Roles ="Admin")]
        public IActionResult UpdateOrderDetail()
        {
            var orderFromDb = _unitOfWork.Order.Get(u => u.OrderId == OrderVM.Order.OrderId);
            orderFromDb.Name = OrderVM.Order.Name;
            orderFromDb.PhoneNumber = OrderVM.Order.PhoneNumber;
            orderFromDb.StreetAddress = OrderVM.Order.StreetAddress;
            orderFromDb.City = OrderVM.Order.City;
            orderFromDb.State = OrderVM.Order.State;
            orderFromDb.PostalCode = OrderVM.Order.PostalCode;
            if (!string.IsNullOrEmpty(OrderVM.Order.Carrier))
            {
                orderFromDb.Carrier = OrderVM.Order.Carrier;
            }
            if (!string.IsNullOrEmpty(OrderVM.Order.Trackingnumber))
            {
                orderFromDb.Trackingnumber = OrderVM.Order.Trackingnumber;
            }
            _unitOfWork.Order.Update(orderFromDb);
            _unitOfWork.Save();

            TempData["Success"] = "Order Details Updated Successfully.";

            return RedirectToAction(nameof(Details), new {id= orderFromDb.OrderId});
        }

        [HttpPost]
        [Authorize(Roles ="Admin")]
        public IActionResult StartProcessing()
        {
            _unitOfWork.Order.UpdateStatus(OrderVM.Order.OrderId, "Processing");
            _unitOfWork.Save();
            TempData["Success"] = "Order Details Updated Successfully";
            return RedirectToAction(nameof(Details), new { id = OrderVM.Order.OrderId });
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult ShipOrder()
        {
            var order = _unitOfWork.Order.Get(u => u.OrderId == OrderVM.Order.OrderId);
            order.Trackingnumber = OrderVM.Order.Trackingnumber;
            order.Carrier = OrderVM.Order.Carrier;
            order.OrderStatus = "Shipped";
            order.ShippingDate = DateTime.Now;


            _unitOfWork.Order.Update(order);
            _unitOfWork.Save();
            TempData["Success"] = "Order Shipped Successfully";
            return RedirectToAction(nameof(Details), new { id = OrderVM.Order.OrderId });
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult CancelOrder()
        {
            var order = _unitOfWork.Order.Get(u => u.OrderId == OrderVM.Order.OrderId);


            _unitOfWork.Order.UpdateStatus(OrderVM.Order.OrderId, "Cancelled");
            _unitOfWork.Save();
            TempData["Success"] = "Order Cancelled Successfully";
            return RedirectToAction(nameof(Details), new { id = OrderVM.Order.OrderId });
        }
    }
}
