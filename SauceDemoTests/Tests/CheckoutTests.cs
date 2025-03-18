using SauceDemoTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoTests.Tests
{
    public class CheckoutTests : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Login("standard_user", "secret_sauce");

            var inventoryPage = new InventoryPage(driver);
            inventoryPage.AddToCartByIndex(1);
            inventoryPage.ClickCartLink();


            cartPage.ClickCheckout();
        }

        [Test]
        public void TestCheckoutPageLoaded()
        {

            Assert.That(checkoutPage.IsPageLoaded, Is.True);
        }

        [Test]
        public void TestContinueToNextStep()
        {

            checkoutPage.EnterFirstName("Teodor");
            checkoutPage.EnterLastName("Dimov");
            checkoutPage.EnterPostalCode("9000");
            checkoutPage.ClickContinueButton();

            Assert.That(checkoutPage.IsSecondStepLoaded, Is.True);
        }

        [Test]
        public void TestCompleteOrder()
        {

            checkoutPage.EnterFirstName("Teodor");
            checkoutPage.EnterLastName("Dimov");
            checkoutPage.EnterPostalCode("9000");
            checkoutPage.ClickContinueButton();
            checkoutPage.ClickFinishButton();

            Assert.That(checkoutPage.IsCheckoutComplete, Is.True);
        }
    }
}
