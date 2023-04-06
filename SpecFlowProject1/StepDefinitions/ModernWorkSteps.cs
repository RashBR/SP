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
    public class ModernWorkSteps
    {

        [When(@"the user selects Modern Work")]
        public void WhenTheUserSelectsModernWork()
        {
            UniversalPage.MordernWorkPage.ModernWork();
        }

        [When(@"the user selects Employee Experience")]
        public void WhenTheUserSelectsEmployeeExperience()
        {
            UniversalPage.MordernWorkPage.EmployeeExperiance();
        }

        [Then(@"the user is able to see the header as '([^']*)'")]
        public void ThenTheUserIsAbleToSeeTheHeaderAs(string expectedHeader)
        {
            string actualHeader = UniversalPage.MordernWorkPage.HeaderOfEmployeeExperiance();
            Assert.That(actualHeader, Is.EqualTo(expectedHeader), "Header is not as expected");
        }

        [Then(@"the user is able to see the paragraph starts with text '([^']*)'")]
        public void ThenTheUserIsAbleToSeeTheParagraphStartsWithText(string expectedSentence)
        {
            string actualSentence = UniversalPage.MordernWorkPage.EmployeeExperiancePara();
            Assert.That(actualSentence, Is.EqualTo(expectedSentence), "Header is not as expected");
        }

    }
}
