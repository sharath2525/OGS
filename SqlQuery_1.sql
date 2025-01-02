CREATE PROCEDURE uspFetchBookWithDiscountedPrice
    @Category VARCHAR(50),
    @DiscountPercent DECIMAL(3, 1)
AS
