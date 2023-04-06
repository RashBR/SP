using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SpecFlowProject1.Actions;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public  class HomePageSteps
    {
        [When(@"the user is on home page")]
        [When(@"the user in the is the application")]
        public void WhenTheUserInTheIsTheApplication()
        {
            UniversalPage.HomePage.AcceptAllCookies();
            
        }

        [When(@"the user selects the Solutions & Services menu")]
        public void WhenTheUserSelectsTheSolutionsServicesMenu()
        {
            UniversalPage.HomePage.ExpandSolutionsAndService();
        }


        

    }
}
