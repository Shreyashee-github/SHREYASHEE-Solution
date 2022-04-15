using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SiteTesting2
{
    class Program
    {
        static void Main(string[] args)
        { 
            string name= "SHREYASHEE PANDIT";
            string email = "shreyashee@gmail.com";
            string CA = "Kolkata";
            string PA = "London";

          

            Console.Write("Test Case Started:");
            IWebDriver driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            Thread.Sleep(2000);

            driver.Navigate().GoToUrl("https://demoqa.com/elements");
            Thread.Sleep(1000);
       
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);


           





            //Text Box-item0
            driver.FindElement(By.Id("item-0")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("userName")).SendKeys(name);
            //driver.FindElement(By.Id("userName"));
            //driver.SendKeys(name);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("userEmail")).SendKeys(email);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("currentAddress")).SendKeys(CA);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("permanentAddress")).SendKeys(PA);
            Thread.Sleep(1000);
            //driver.FindElement(By.Id("submit")).Click();
            //Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("submit")).Click();



            //Check Box-item1
            driver.FindElement(By.Id("item-1")).Click();
            Thread.Sleep(2000);
            //driver.FindElement(By.XPath("//*[Text()='Home']")).Click();
            //driver.FindElement(By.TagName("//*[button()='Expand all']")).Click();
            //Thread.Sleep(2000);
            //driver.FindElement(By.XPath("//aria-label()='Expand all']")).Click();
            driver.FindElement(By.ClassName("rct-option-expand-all")).Click();
            Thread.Sleep(2000);


            //Radio Button-item2
            driver.FindElement(By.Id("item-2")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//label[@for='yesRadio']")).Click();
            //driver.FindElement(By.XPath("//label[@for='impressiveRadio']")).Click();
            //driver.FindElement(By.XPath("//label[@for='noRadio']")).Click();
            //driver.FindElement(By.Id("yesRadio")).Click();
            //driver.FindElement(By.Id("impressiveRadio")).Click();
            //driver.FindElement(By.Id("noRadio")).Click();
            Thread.Sleep(2000);


            //Web Tables-item3
            driver.FindElement(By.Id("item-3")).Click();
            Thread.Sleep(2000);
            string fname = "SHREYASHEE"; 
            string lname = "PANDIT"; 
            string age = "25"; 
            string salary = "900000000000000";
            string dept = "Engineer";
            string search = "SHREYASHEE";
            //driver.FindElement(By.XPath("//*[Text()='Web Tables']")).Click();
            driver.FindElement(By.XPath("//*[text()='Add']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("firstName")).SendKeys(fname);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("lastName")).SendKeys(lname);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("userEmail")).SendKeys(email);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("age")).SendKeys(age);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("salary")).SendKeys(salary);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("department")).SendKeys(dept);
            Thread.Sleep(2000);
            //Driver.FindElement(By.Id("department")).SendKeys(Keys.Enter);
            driver.FindElement(By.Id("submit")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("searchBox")).SendKeys(search);
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,200)");
            driver.FindElement(By.Id("delete-record-4")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("searchBox")).Clear();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,200)");

            //Buttons-item4
            driver.FindElement(By.Id("item-4")).Click();
            Thread.Sleep(2000);

            Actions ac = new Actions(driver);

            ac.MoveToElement(driver.FindElement(By.Id("doubleClickBtn"))).DoubleClick().Build().Perform();
            Thread.Sleep(2000);
            ac.MoveToElement(driver.FindElement(By.Id("rightClickBtn"))).ContextClick().Build().Perform();
            Thread.Sleep(2000);
            //ac.MoveToElement(driver.FindElement(By.Id("gaWl0"))).ContextClick().Build().Perform();
            driver.FindElement(By.XPath("//*[text()='Click Me']")).Click();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);


            //Links-item5
            driver.FindElement(By.Id("item-5")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("simpleLink")).Click();
            Thread.Sleep(2000);
            string a;
            string b;
            a = driver.WindowHandles[0]; 
            b = driver.WindowHandles[1];

            driver.SwitchTo().Window(b);
            driver.Manage().Window.Minimize();
            driver.Close();
            Thread.Sleep(2000);
            driver.SwitchTo().Window(a);
            driver.FindElement(By.Id("dynamicLink")).Click();
            Thread.Sleep(2000);
            b = driver.WindowHandles[1];
            driver.SwitchTo().Window(b);
            driver.Manage().Window.Minimize();
            driver.Close();
            Thread.Sleep(2000);
            driver.SwitchTo().Window(a);
            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("created")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("no-content")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("moved")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("bad-request")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("unauthorized")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("forbidden")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("invalid-url")).Click();
            Thread.Sleep(2000);


            //Broken Links Images-item6
            driver.FindElement(By.Id("item-6")).Click();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);



            //Upload Download-item7
            driver.FindElement(By.Id("item-7")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("downloadButton")).Click();
            Thread.Sleep(4000);
            js.ExecuteScript("window.scrollBy(0,400)");
            Thread.Sleep(2000);



            //Dynamic Properties-item8
            driver.FindElement(By.Id("item-8")).Click();
            Thread.Sleep(7000);
            driver.Manage().Window.Minimize();
            Console.Write("Test Case Ended:");
            driver.Close();
            driver.Dispose();
            driver.Quit();

        }
    }
}
