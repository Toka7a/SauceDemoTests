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
        private readonly By cartLink = By.XPath("//a[@class='shopping_cart_link']");
        private readonly By inventoryItems = By.XPath("//div[@class='inventory_item']");
        
        public InventoryPage(IWebDriver driver) : base(driver) { }
        
        public bool IsPageLoaded()
        {
            return GetText(productsTitle) == "Products" && driver.Url.Contains("inventory.html");
        }

        public void AddToCartByIndex(int itemIndex)
        {
            var itemAddToCartButton = By.XPath($"(//div[@class='inventory_item'])[{itemIndex}]//button");
            Click(itemAddToCartButton);
        }

        public void AddToCartByName(string name)
        {
            var itemToAdd = By.XPath($"//div[text()='{name}']/ancestor::div[@class='inventory_item']//button");
            Click(itemToAdd);
        }

        public void ClickCartLink()
        {
            Click(cartLink);
        }

        public bool IsInventoryDisplayed()
        {
            return FindElements(inventoryItems).Any();
        }
    }
}
