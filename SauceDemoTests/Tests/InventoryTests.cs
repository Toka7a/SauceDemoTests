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
            Assert.That(inventoryPage.IsInventoryDisplayed(), Is.True);
        }

        [Test]
        public void TestAddToCartByIndex()
        {
            inventoryPage.AddToCartByIndex(1);
            inventoryPage.ClickCartLink();

            Assert.That(cartPage.IsCartItemDisplayed(), Is.True);
        }

        [Test]
        public void TestAddToCartByName()
        {
            inventoryPage.AddToCartByName("Sauce Labs Bolt T-Shirt");
            inventoryPage.ClickCartLink();

            Assert.That(cartPage.IsCartItemDisplayed(), Is.True);
        }

        [Test]
        public void TestPageTitle()
        {

            Assert.That(inventoryPage.IsPageLoaded(), Is.True);
        }
    }
}
