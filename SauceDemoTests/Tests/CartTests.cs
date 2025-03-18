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

            inventoryPage.AddToCartByIndex(1);
            inventoryPage.ClickCartLink();
        }

        [Test]
        public void TestCartItemDisplayed()
        {

            Assert.That(cartPage.IsCartItemDisplayed, Is.True);
        }

        [Test]
        public void TestClickCheckout()
        {

            cartPage.ClickCheckout();
            
            Assert.That(checkoutPage.IsPageLoaded, Is.True);
        }
    }
}
