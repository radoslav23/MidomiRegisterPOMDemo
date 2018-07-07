using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidomiRegisterPOMDemo.UserRegData
{
    public class UserRegistration
    {
        private string email;
        private string username;
        private string password;
        private string confirmPassword;
        private string birthMonth;
        private string birthDay;
        private string birthYear;
        private string termsOfUse;
        private string continueButton;
        private string skipStepButton;
        //auto generated constructor
        //public UserRegistration(string v1, string v2, string v3, string v4, string v5, string v6, string v7)
        //{
        //}

        public UserRegistration(String email,
                                String username,
                                String password,
                                String confirmPassword,
                                String birthMonth,
                                String birthDay,
                                String birthYear)
                               // String termsOfUse,
                               // String continueButton)
        {
            this.email = email;
            this.username = username;
            this.password = password;
            this.confirmPassword = confirmPassword;
            this.birthMonth = birthMonth;
            this.birthDay = birthDay;
            this.birthYear = birthYear;
           // this.termsOfUse = termsOfUse;
           // this.continueButton = continueButton;
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value;  }
        }
        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.username = value; }
        }
        public string ConfirmPassword
        {
            get { return this.confirmPassword; }
            set { this.confirmPassword = value; }
        }
        public string BirthMonth
        {
            get { return this.birthMonth; }
            set { this.birthMonth = value; }
        }
        public string BirthDay
        {
            get { return this.birthDay; }
            set { this.birthDay = value; }
        }
        public string BirthYear
        {
            get { return this.birthYear; }
            set { this.birthYear = value; }
        }
        //public string TermsOfUse
        //{
        //    get { return this.termsOfUse; }
        //    set { this.termsOfUse = value; }
        //}
        //public string ContinueButton
        //{
        //    get { return this.continueButton; }
        //    set { this.continueButton = value; }
        //}
    }
}
