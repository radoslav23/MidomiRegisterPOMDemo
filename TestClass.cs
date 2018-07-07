using MidomiRegisterPOMDemo.Pages.RegistrationPage;
using MidomiRegisterPOMDemo.UserRegData;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidomiRegisterPOMDemo
{
    [TestFixture]
    public class TestClass
    {
        string requiredField = "*This field is required";
        public IWebDriver driver;
        //declare chrome driver
        [SetUp]
        public void Init()
        {
            this.driver = new ChromeDriver();
        }
        //declare driver stoping after test end
        [TearDown]
        public void CleanUp()
        {
            //this.driver.Quit();
        }

        [Test]
        public void MidomiRegisterTest()
        {
            var regPage = new RegistrationPage(this.driver);
            UserRegistration user = new UserRegistration("toster5@gmail.com",
                                                         "toster5",
                                                         "qwerty",
                                                         "qwerty",
                                                         "August",
                                                         "10",
                                                         "1999");
            regPage.NavigateTo();
            regPage.FillRegisterForm(user);
        }
        [Test]
        public void MidomiRegisterWithoutEmail()
        {
            var regPage = new RegistrationPage(this.driver);
            UserRegistration user = new UserRegistration("",
                                                         "toster6",
                                                         "qwerty",
                                                         "qwerty",
                                                         "August",
                                                         "10",
                                                         "1999");
            regPage.NavigateTo();
            regPage.FillRegisterForm(user);
            regPage.AssertWithoutEmailMessage("Please enter a valid email address");
        }
        [Test]
        public void MidomiRegisterWithInvalidEmail()
        {
            var regPage = new RegistrationPage(this.driver);
            UserRegistration user = new UserRegistration("1111111111111",
                                                         "toSt99",
                                                         "qwerty",
                                                         "qwerty",
                                                         "August",
                                                         "10",
                                                         "1999");
            regPage.NavigateTo();
            regPage.FillRegisterForm(user);
            regPage.AssertNoValidEmail("Please enter a valid email address.");
        }
        [Test]
        public void MidomiRegisterWithInvalidUsername()
        {
            var regPage = new RegistrationPage(this.driver);
            UserRegistration user = new UserRegistration("helikopter@gmail.com",
                                                         "to",
                                                         "qwerty",
                                                         "qwerty",
                                                         "August",
                                                         "10",
                                                         "1999");
            regPage.NavigateTo();
            regPage.FillRegisterForm(user);
            regPage.AssertNoValidUsername("Please enter a username between 3 and 10 characters long.");    
        }
        [Test]
        public void MidomiRegisterPassNotEnoughSymbols()
        {
            var regPage = new RegistrationPage(this.driver);
            UserRegistration user = new UserRegistration("helikopter@gmail.com",
                                                         "to78st",
                                                         "qwer",
                                                         "qwer",
                                                         "August",
                                                         "10",
                                                         "1999");
            regPage.NavigateTo();
            regPage.FillRegisterForm(user);
            regPage.AssertNoValidPassword("Please enter a password between 5 and 45 characters long.");
        }
        [Test]
        public void MidomiRegisterNoMatchPasswords()
        {
            var regPage = new RegistrationPage(this.driver);
            UserRegistration user = new UserRegistration("helikopter@gmail.com",
                                                         "to78st",
                                                         "qwerty9",
                                                         "qwertyy",
                                                         "August",
                                                         "10",
                                                         "1999");
            regPage.NavigateTo();
            regPage.FillRegisterForm(user);
            regPage.AssertNoMatchingPasswords("Password and confirm password values do not match.");            
        }
        [Test]
        public void MidomiRegisterForbiddenSymbolsPassword()
        {
            var regPage = new RegistrationPage(this.driver);
            UserRegistration user = new UserRegistration("helikopter@gmail.com",
                                                         "to78st",
                                                         "ase@#",
                                                         "ase@#",
                                                         "August",
                                                         "10",
                                                         "1999");
            regPage.NavigateTo();
            regPage.FillRegisterForm(user);
            regPage.AssertForbiddenSymbolsPassword("Please do not use any special characters other than underscore, dash or period for your username.");
        }
    }
}
