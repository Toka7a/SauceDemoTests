using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoTests.Pages
{
    public class CheckoutPage : BasePage
    {
        private readonly By firstNameField = By.XPath("//input[@id='first-name']");
        private readonly By lastNameField = By.XPath("//input[@id='last-name']");
        private readonly By postalCodeField = By.XPath("//input[@id='postal-code']");
        private readonly By continueButton = By.XPath("//input[@id='continue']");
        private readonly By finishButton = By.XPath("//button[@id='finish']");
        private readonly By completeHeader = By.XPath("//h2[@class='complete-header']");

        public CheckoutPage(IWebDriver driver) : base(driver) { }
        
        public void EnterFirstName(string firstName)
        {
            Type(firstNameField, firstName);
        }

        public void EnterLastName(string lastName)
        {
            Type(lastNameField, lastName);
        }

        public void EnterPostalCode(string postalCode)
        {
            Type(postalCodeField, postalCode);
        }

        public void ClickContinueButton()
        {
            Click(continueButton);
        }

        public void ClickFinishButton()
        {
            Click(finishButton);
        }

        public bool IsPageLoaded()
        {
            return driver.Url.Contains("checkout-step-one.html") || driver.Url.Contains("checkout-step-two.html");
        }

        public bool IsCheckoutComplete()
        {
            return GetText(completeHeader) == "Thank you for your order!";
        }

        public bool IsSecondStepLoaded()
        {
            return driver.Url.Contains("checkout-step-two.html");
        }
    }
}
