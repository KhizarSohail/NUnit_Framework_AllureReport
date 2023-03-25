using NUnit.Allure.Attributes;
using NUnit.Allure.Core;

namespace AllureReport_AdactineHotel
{
    [AllureNUnit]
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            BaseClass.SeleniumInit();
        }
        [TearDown] public void Teardown()
        {
            BaseClass.driver.Close();
        }

        [Test]
        public void Test1()
        {
            Login lg = new Login();
            lg.ValidLogin("https://adactinhotelapp.com/", "user2here","user123");
        }
        
        [Test]
        public void Test2()
        {
            Register reg = new Register();
            reg.UserRegister();
        }
    }
}