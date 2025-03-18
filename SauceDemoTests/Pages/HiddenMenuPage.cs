using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoTests.Pages
{
    public class HiddenMenuPage : BasePage
    {
        private readonly By menuButton = By.XPath("//button[@id='react-burger-menu-btn']");
        private readonly By logoutButton = By.XPath("//a[@id='logout_sidebar_link']");
        
        public HiddenMenuPage(IWebDriver driver) : base(driver) { }
        

        public void ClickMenuButton()
        {
           Click(menuButton);
        }

        public void ClickLogoutButton()
        {
            Click(logoutButton);
        }

        public bool IsMenuOpen()
        {
            return FindElement(logoutButton).Displayed;
        }
    }
}
