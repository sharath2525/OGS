using adminmvc.Models;

namespace adminmvc.ViewModels
{
    public class OrderVM
    {
        public Order Order { get; set; }
        public IEnumerable<OrderDetail> OrderDetail { get; set;  }
    }
}
