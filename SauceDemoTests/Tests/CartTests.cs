using SauceDemoTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoTests.Tests
{
    public class CartTests : BaseTest
    {
        [SetUp]
        public void SetUpMethod()
        {
            Login("standard_user", "secret_sauce");

            var inventoryPage = new InventoryPage(driver);
            inventoryPage.AddToCartByIndex(1);
            inventoryPage.ClickCartLink();
        }

        [Test]
        public void TestCartItemDisplayed()
        {
            var cartPage = new CartPage(driver);

            Assert.That(cartPage.IsCartItemDisplayed, Is.True);
        }

        [Test]
        public void TestClickCheckout()
        {
            var cartPage = new CartPage(driver);

            cartPage.ClickCheckout();

            //TODO Use checkout page to do this assertion
            Assert.That(driver.Url, Is.EqualTo("https://www.saucedemo.com/checkout-step-one.html"));
        }
    }
}
