using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2nd_Homework___Design_Patterns.Models;
using MidomiRegisterPOMDemo.UserRegData;
using OpenQA.Selenium;

namespace MidomiRegisterPOMDemo.Pages.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        //auto generated constructor
        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }
        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl("https://www.midomi.com/index.php?action=main.register_account&post_login_url=");
        }

        public void FillRegisterForm(UserRegistration user)
        {
            Type(this.Email, user.Email);
            Type(this.Username, user.Username);
            Type(this.Password, user.Password);
            Type(this.ConfirmPassword, user.ConfirmPassword);
            this.BirthMonthChoise.SelectByText(user.BirthMonth);
            this.BirthDayChoise.SelectByText(user.BirthDay);
            this.BirthYearChoise.SelectByText(user.BirthYear);
            this.TermsOfUse.Click();
            this.ContinueButton.Click();
        }
        public void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
    }
}
