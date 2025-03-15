using SauceDemoTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoTests.Tests
{
    public class LoginTests : BaseTest
    {
        [Test]
        public void TestLoginWithValidCredentials()
        {
            Login("standard_user", "secret_sauce");

            var inventoryPage = new InventoryPage(driver);
            Assert.That(inventoryPage.IsPageLoaded, Is.True, "Login was not succsessful");
        }

        [Test]
        public void TestLoginWithInvalidCredentials()
        {
            Login("Invalid", "Invalid");

            var loginPage = new LoginPage(driver);
            string errorMessage = loginPage.GetErrorMessage();

            Assert.That(errorMessage, Is.EqualTo("Epic sadface: Username and password do not match any user in this service"), "User was able to log in");
        }

        [Test]
        public void TestLoginWithLockedOutUser()
        {
            Login("locked_out_user", "secret_sauce");

            var loginPage = new LoginPage(driver);
            string errorMessage = loginPage.GetErrorMessage();

            Assert.That(errorMessage, Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
        }
    }
}
