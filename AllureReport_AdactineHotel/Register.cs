using AllureReport_AdactineHotel;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AllureReport_AdactineHotel
{
    internal class Register : BaseClass
    {
        public void UserRegister()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://adactinhotelapp.com/";
            driver.FindElement(By.ClassName("login_register")).Click();
            driver.FindElement(By.Id("username")).SendKeys("Khaytyt56r4535");
            driver.FindElement(By.Id("password")).SendKeys("Khan123456");
            driver.FindElement(By.Id("re_password")).SendKeys("Khan123456");
            driver.FindElement(By.Id("full_name")).SendKeys("Haris terdgfwr");
            driver.FindElement(By.Id("email_add")).SendKeys("tdjkjted@gmail.com");
            Thread.Sleep(5000);
            driver.FindElement(By.Id("tnc_box")).Click();
            driver.FindElement(By.Id("Submit")).Click();

            //driver.FindElement(By.CssSelector("body > table.content > tbody > tr > td:nth-child(1) > table > tbody > tr > td > a")).Click();
            //driver.FindElement(By.Id("username")).SendKeys("AmirImam");
            //driver.FindElement(By.Id("password")).SendKeys("AmirImam");
            //driver.FindElement(By.Id("login")).Click();
            //string welcomeText = driver.FindElement(By.ClassName("welcome_menu")).Text;
            //Assert.AreEqual("Welcome to Adactin Group of Hotels", welcomeText);
        }
    }
}
