using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Support
{
    [Binding]
    public sealed class UIHooks : Hooks
    {
        private static ExtentReports extentReport;
        public UIContext context { get;private set; }

        public UIHooks(UIContext uIContext)
        {
            context = uIContext;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            UICommonSelenium.LanchBrowser("Chrome");

        }

        

        [AfterScenario]
        [Scope(Tag ="UI")]
        public void UITearDown(ScenarioContext scenarioContext)
        {
            if (scenarioContext.ScenarioInfo.Tags.Contains("QuitBrowser") || scenarioContext.TestError != null)
            {
                QuitAndOpenNewBrowser();
                return;
            }
                
        }

        

        [AfterTestRun]
        public static void Teardown()
        {
            Console.WriteLine("TearDown");
            if(UICommonSelenium.Driver != null)
            {
                UICommonSelenium.Driver.Quit();
            }
        }

        public void QuitAndOpenNewBrowser()
        {
            UICommonSelenium.Driver.Quit();
            UICommonSelenium.LanchBrowser(UICommonSelenium.SeleniumSettings.Browser);
            UICommonSelenium.loginFlag = false;
        }

    }
}
