using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidomiRegisterPOMDemo.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        //auto generated constructor
        public HomePage(IWebDriver driver) : base(driver)
        {
        }
        //home page's url
        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl("https://www.midomi.com");
        }
    }
}
