using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidomiRegisterPOMDemo.Pages.HomePage
{
    public partial class HomePage
    {
        //registration link on home page
        [FindsBy(How = How.ClassName, Using = "link_text")]
        [CacheLookup]
        public IWebElement Registration { get; set; }
    }
}
