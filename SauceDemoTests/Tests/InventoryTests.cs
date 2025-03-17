using SauceDemoTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoTests.Tests
{
    public class InventoryTests : BaseTest
    {
        [SetUp]
        public void SetUpToLogin()
        {
            Login("standard_user", "secret_sauce");
        }
        [Test]
        public void TestInventoryDisplay()
        {
            var inventoryPage = new InventoryPage(driver);
            Assert.That(inventoryPage.IsInventoryDisplayed(), Is.True);
        }

        [Test]
        public void TestAddToCartByIndex()
        {
            var inventoryPage = new InventoryPage(driver);
            inventoryPage.AddToCartByIndex(1);
            inventoryPage.ClickCartLink();

            var cartPage = new CartPage(driver);
            Assert.That(cartPage.IsCartItemDisplayed(), Is.True);
        }

        [Test]
        public void TestAddToCartByName()
        {
            var inventoryPage = new InventoryPage(driver);
            inventoryPage.AddToCartByName("Sauce Labs Bolt T-Shirt");
            inventoryPage.ClickCartLink();

            var cartPage = new CartPage(driver);
            Assert.That(cartPage.IsCartItemDisplayed(), Is.True);
        }

        [Test]
        public void TestPageTitle()
        {
            var inventoryPage = new InventoryPage(driver);

            Assert.That(inventoryPage.IsPageLoaded(), Is.True);
        }
    }
}
