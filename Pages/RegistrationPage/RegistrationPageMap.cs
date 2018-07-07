using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidomiRegisterPOMDemo.Pages.RegistrationPage
{
    public partial class RegistrationPage
    {
        public IWebElement Email
        {
            get
            {
                return this.Driver.FindElement(By.Id("email"));
            }
        }
        public IWebElement Username
        {
            get
            {
                return this.Driver.FindElement(By.Id("username"));
            }
        }
        public IWebElement Password
        {
            get
            {
                return this.Driver.FindElement(By.Id("password"));
            }
        }
        public IWebElement ConfirmPassword
        {
            get
            {
                return this.Driver.FindElement(By.Id("confirm_password"));
            }
        }
        private IWebElement SelectBirthMonth
        {
            get
            {
                return this.Driver.FindElement(By.Id("birth_month"));
            }
        }
        public SelectElement BirthMonthChoise
        {
            get
            {
                return new SelectElement(SelectBirthMonth);
            }
        }
        private IWebElement SelectBirthDay
        {
            get
            {
                return this.Driver.FindElement(By.Id("birth_day"));
            }
        }
        public SelectElement BirthDayChoise
        {
            get
            {
                return new SelectElement(SelectBirthDay);
            }
        }
        private IWebElement SelectBirthYear
        {
            get
            {
                return this.Driver.FindElement(By.Id("birth_year"));
            }
        }
        public SelectElement BirthYearChoise
        {
            get
            {
                return new SelectElement(SelectBirthYear);
            }
        }
        public IWebElement TermsOfUse
        {
            get
            {
                return this.Driver.FindElement(By.Id("tos_pp"));
            }
        }
        public IWebElement ContinueButton
        {
            get
            {
                return this.Driver.FindElement(By.Id("submitLink"));
            }
        }
        public IWebElement WithoutEmail
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("email")));
                return this.Driver.FindElement(By.Id("email"));
            }
        }
        public IWebElement NoValidEmail
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("email")));
                return this.Driver.FindElement(By.Id("email"));
            }
        }
        public IWebElement NoValidUsername
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("username")));
                return this.Driver.FindElement(By.Id("username"));
            }
        }
        public IWebElement NotEnoughSymbolsPassword
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("password")));
                return this.Driver.FindElement(By.Id("password"));
            }
        }   
        public IWebElement NoMatchingPasswords
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("password")));
                return this.Driver.FindElement(By.Id("password"));
            }
        }
        public IWebElement ForbiddenSymbolsPassword
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("password")));
                return this.Driver.FindElement(By.Id("password"));
            }
        }
    }
}
