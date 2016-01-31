using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Interactions.Internal;

namespace SeleniumGrid
{
    class Grid
    {
        public  IWebDriver driver;
        public void setup()
        {
            
            //string test;
            //System.Environment.SetEnvironmentVariable("webdriver.ie.driver", @"C:\Selenium_Lib\IEDriverServer_Win32_2.48.0\IEDriverServer.exe");
            DesiredCapabilities cap = new DesiredCapabilities();
            cap = DesiredCapabilities.InternetExplorer();
            cap.SetCapability(CapabilityType.BrowserName, "internet explorer");
            //test = Environment.GetEnvironmentVariable("webdriver.ie.driver");
            //Console.WriteLine(test);
            cap.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
            driver = new RemoteWebDriver(new Uri("http://192.168.1.34:4444/wd/hub"), cap);
        }
    }
}
