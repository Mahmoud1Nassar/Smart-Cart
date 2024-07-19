using Smart_Cart;
namespace SmartCartTest

{
    public class UnitTest1
    {
        private ShoppingCart _cart;
        private Product _apple;
        private Product _tShirt;
        private Product _laptop;

        public UnitTest1()
        {
            _cart = new ShoppingCart();
            _apple = new Product("Apple", 0.50m, Product.ProductCategory.Food);
            _tShirt = new Product("T-Shirt", 15.99m, Product.ProductCategory.Clothing);
            _laptop = new Product("Laptop", 999.99m, Product.ProductCategory.Electronics);
        }

        [Fact]
        public void AddItem_ShouldAddProductToCart()
        {
            // Act
            _cart.AddItem(_apple);

            // Assert
            Assert.Contains(_apple, _cart.Cart);
        }

        [Fact]
        public void RemoveItem_ShouldRemoveProductFromCart()
        {
            // Arrange
            _cart.AddItem(_apple);

            // Act
            _cart.RemoveItem(_apple);

            // Assert
            Assert.DoesNotContain(_apple, _cart.Cart);
        }

        [Fact]
        public void CalculateTotalCost_ShouldReturnCorrectTotal()
        {
            // Arrange
            _cart.AddItem(_apple);
            _cart.AddItem(_tShirt);
            _cart.AddItem(_laptop);

            // Act
            var total = _cart.CalculateToalCost();

            // Assert
            Assert.Equal("Total Price: 1016.48", total);
        }
    }

}
