using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllureReport_AdactineHotel
{
    internal class SearchHotel : BaseClass
    {
        //by locationdd = by.id("location");
        //by hoteldd = by.id("hotels");
        //by roomtypedd = by.id("room_type");
        //by noofroomdd = by.id("room_nos");
        //by checkindatetxt = by.id("datepick_in");
        //by checkoutdatetxt = by.id("datepick_out");
        //by adultperroomdd = by.id("adult_room");
        //by childperroomdd = by.id("child_room");
        //by searchbtn = by.id("submit");
        //by resetbtn = by.id("reset");

        public void searchHotel(string url, string uname, string pass, string loc, string hotel, string roomtype,
            string roomNo, string datepick, string dateleave, string adultroom, string childroom)
        {
            driver.Url = url;
            driver.FindElement(By.Id("username")).SendKeys(uname);
            driver.FindElement(By.Id("password")).SendKeys(pass);
            driver.FindElement(By.Id("location")).SendKeys(loc);
            driver.FindElement(By.Id("hotels")).SendKeys(hotel);
            driver.FindElement(By.Id("room_type")).SendKeys(roomtype);
            driver.FindElement(By.Id("room_nos")).SendKeys(roomNo);
            driver.FindElement(By.Id("datepick_in")).SendKeys(datepick);
            driver.FindElement(By.Id("datepick_out")).SendKeys(dateleave);
            driver.FindElement(By.Id("adult_room")).SendKeys(adultroom);
            driver.FindElement(By.Id("child_room")).SendKeys(childroom);
            driver.FindElement(By.Id("Submit")).Click();
            BaseClass.driver.Close();
        }
    }
}
