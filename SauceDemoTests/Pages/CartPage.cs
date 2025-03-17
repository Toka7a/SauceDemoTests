using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoTests.Pages
{
    public class CartPage : BasePage
    {
        private readonly By cartItems = By.XPath("//div[@class='cart_item']");
        private readonly By checkoutButton = By.XPath("//button[@name='checkout']");

        public CartPage(IWebDriver driver) : base(driver) { }
        
        public bool IsCartItemDisplayed()
        {
            return FindElement(cartItems).Displayed;
        }

        public void ClickCheckout()
        {
            Click(checkoutButton);
        }
    }
}
