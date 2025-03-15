using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoTests.Pages
{
    public class InventoryPage : BasePage
    {
        private readonly By productsTitle = By.XPath("//span[@data-test='title']");
        public InventoryPage(IWebDriver driver) : base(driver) { }
        
        public bool IsPageLoaded()
        {
            return GetText(productsTitle) == "Products" && driver.Url.Contains("inventory.html");
        }
    }
}
