using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoTests.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver) { }

        private readonly By usernameField = By.XPath("//input[@id='user-name']");
        private readonly By passwordField = By.XPath("//input[@id='password']");
        private readonly By loginButton = By.XPath("//input[@id='login-button']");
        private readonly By errorMessage = By.XPath("//h3[@data-test='error']");


        public void InputUsername(string username)
        {
            Type(usernameField, username);
        }

        public void InputPassword(string password)
        {
            Type(passwordField, password);
        }

        public void ClickLoginButton()
        {
            Click(loginButton);
        }

        public string GetErrorMessage()
        {
           return GetText(errorMessage);
        }
    }
}
