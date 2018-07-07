using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidomiRegisterPOMDemo.Pages.RegistrationPage
{
    public static class RegistrationPageAsserter
    {
        public static void AssertWithoutEmailMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.WithoutEmail.Displayed);
        }
        public static void AssertNoValidEmail(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.NoValidEmail.Displayed);
        }
        public static void AssertNoValidUsername(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.NoValidUsername.Displayed);
        }
        public static void AssertNoValidPassword(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.NotEnoughSymbolsPassword.Displayed);
        }
        public static void AssertNoMatchingPasswords(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.NoMatchingPasswords.Displayed);
        }
        public static void AssertForbiddenSymbolsPassword(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ForbiddenSymbolsPassword.Displayed);
        }
    }
}
