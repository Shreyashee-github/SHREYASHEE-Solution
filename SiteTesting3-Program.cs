using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SiteTesting3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver d = new ChromeDriver();
            IJavaScriptExecutor js= (IJavaScriptExecutor)d;


            //Agent FrontEnd

            string city = "London,United Kingdom";
            string value = "4";

            Console.WriteLine("Test Case Started");

            d.Navigate().GoToUrl("https://phptravels.com/demo");
            Thread.Sleep(1000);
            d.Manage().Window.Maximize();
            Thread.Sleep(4000);
            //js.ExecuteScript("window.scrollBy(0,400)");
            //Thread.Sleep(2000);
            d.FindElement(By.XPath("//a[@href='//www.phptravels.net/login']")).Click();
            Thread.Sleep(4000);


            string a = d.WindowHandles[0];
            string b = d.WindowHandles[1];
            d.SwitchTo().Window(b);
            //////////d.FindElement(By.XPath("//a[@href='//www.phptravels.net/'  and  @title='home']")).Click();
            d.FindElement(By.XPath("//*[text()='Home']")).Click();
            //d.FindElement(By.XPath("//a[@title='home']")).Click();
            Thread.Sleep(2000);


            //Search by City
            d.FindElement(By.XPath("//span[@data-select2-id='1']//span[@tabindex='0']")).SendKeys(city);
            d.FindElement(By.XPath("//*[@id='fadein']/span/span/span[1]/input")).SendKeys("Lon"); 
            Thread.Sleep(2000); 
            d.FindElement(By.XPath("//ul[@id='select2-hotels_city-results']/li[contains(text(), 'London,United Kingdom')]")).Click();
            //d.FindElement(By.XPath("//input[@type='search']")).SendKeys(city);
            //d.FindElement(By.XPath("//input[@tabindex='0']")).SendKeys(city);
            //d.FindElement(By.XPath("//input[@class='select2-search__field']")).SendKeys(city);
            //Thread.Sleep(2000);

            //CheckIn
            d.FindElement(By.XPath("//input[@id='checkin']")).Click(); 
            Thread.Sleep(2000);
            d.FindElement(By.XPath("//*[text()='25']")).Click();
            //d.FindElement(By.XPath("//td[@class='day' and text()='25']")).Click(); 
            Thread.Sleep(2000);


            //CheckOut
            d.FindElement(By.XPath("//input[@id='checkout']")).Click();
            Thread.Sleep(2000);
            d.FindElement(By.XPath("//*[text()='29']")).Click();

            /////////d.FindElement(By.XPath("//td[@class='day ']//*[text()='29']")).Click();
            /////////d.FindElement(By.XPath("//td[@class='day active']/td[@text()='26']")).Click();

            Thread.Sleep(2000);



            //Traveller
            d.FindElement(By.XPath("//a[@class='dropdown-toggle dropdown-btn travellers waves-effect']")).Click();
            Thread.Sleep(1000);
            d.FindElement(By.XPath("//div[@class='dropdown-menu dropdown-menu-wrap']")).Click();
            Thread.Sleep(1000);
            d.FindElement(By.XPath("//div[@class='roomBtn d-flex align-items-center justify-content-between']")).Click();
            Thread.Sleep(1000);
            d.FindElement(By.XPath("//div[@id='adults']")).SendKeys(value);
            d.FindElement(By.XPath("//i[@class='la la-plu']")).Click();


            d.FindElement(By.XPath("//select[@class='form-select nationality']")).Click();
            d.FindElement(By.XPath("//option[@value='IN'])]")).Click();


            d.FindElement(By.XPath("*[@id='nationality']/option[contains(text(), 'India']")).Click();
            d.FindElement(By.XPath("//select[@id='nationality']/option[contains(text(), 'India')]")).Click();

            //d.FindElement(By.XPath("//div[@class='dropdown-item']")).Click();


            //Submit Button
            d.FindElement(By.XPath("//button[@id='submit']")).Click();

            d.Manage().Window.Minimize();
            Thread.Sleep(1000);
            Console.WriteLine("Test Case Closed");
            Thread.Sleep(1000);

            d.Close();
            d.Dispose();
            d.Quit();
        }
    }
}
