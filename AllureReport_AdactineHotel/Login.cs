using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllureReport_AdactineHotel
{
    internal class Login : BaseClass
    {
        public void ValidLogin(string url, string user, string pass)
        {
            driver.Url = url;
            driver.FindElement(By.Id("username")).SendKeys(user);
            driver.FindElement(By.Name("password")).SendKeys(pass);
            driver.FindElement(By.ClassName("login_button")).Click();

        }
    }
}
