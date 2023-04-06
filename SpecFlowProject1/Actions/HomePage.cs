using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Actions
{
    public class HomePage : UniversalPage
    {
        #region Locator
        string homePageTitle = "xpath=//img[@title='Spanish Point Technologies']";
        string acceptAllCookiesBtn = "xpath=//*[contains(text(),'Accept All Cookies') and @role='button']";
        string navBar = "//*[contains(@class,'navbar-toggle collapsed') and @type='button']";
        string SolutionsAndServicesBtn = "xpath=//div[@id='menutop']// span[text()= 'Solutions & Services']";
        #endregion


        public HomePage AcceptAllCookies()
        {
            Click(acceptAllCookiesBtn, 3, ClickType.Click);
            return new HomePage();
        }
        public string HomePageTitle()
        {
            return GetTitle();
        }

        public HomePage NavigationBarExpand()
        {
            Click(navBar, 3, ClickType.Click);
            return new HomePage();
        }

        public HomePage ExpandSolutionsAndService()
        {
            Click(SolutionsAndServicesBtn, 3);
            return new HomePage();  
        }
    }
}
