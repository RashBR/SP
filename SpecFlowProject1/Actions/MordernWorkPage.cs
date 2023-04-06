using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace SpecFlowProject1.Actions
{
    public class MordernWorkPage : UniversalPage
    {
        #region Locators
        string modernworkbutton = "xpath=//li[contains(@id, 'menu-item')]//a[contains(@href, 'modern-work/')]";
        string SolutionsAndServicesBtn = "xpath=//div[@id='menutop']// span[text()= 'Solutions & Services']";
        string employeeExperianceButton = "xpath=//div[contains(@class,'tabs-container')]/descendant:: a [2]";
           // "xpath=//div[contains(@class,'tabs-container')]//span[text() ='Employee Experience']/..";
        string HeaderEmployeeExp = "xpath=//h3[(text()='Employee Experience')]";
        string EmployeeExpPara = "xpath=//strong[contains(text(),'Engaging, ')]";
        #endregion
        
        public MordernWorkPage ModernWork()
        {
            Click(modernworkbutton, 5, ClickType.Click);
            return new MordernWorkPage();
        }

        public MordernWorkPage EmployeeExperiance()
        {
           
            Click(employeeExperianceButton, 10, ClickType.Click);
            return new MordernWorkPage();
        }

        public string HeaderOfEmployeeExperiance()
        {
            return GetElementText(HeaderEmployeeExp, 3);
        }

        public string EmployeeExperiancePara()
        {
            return GetElementText(EmployeeExpPara, 3);
        }
    }
}
