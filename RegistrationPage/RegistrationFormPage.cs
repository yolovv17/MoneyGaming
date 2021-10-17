using GANUIAssignment.RegistrationPage.BasePages;
using OpenQA.Selenium;

namespace GANUIAssignment.RegistrationPage
{
    public class RegistrationFormPage : BasePage
    { 
        public RegistrationFormPage(IWebDriver driver)
            : base(driver) 
        {

        }

        public IWebElement joinNow => Wait.Until(d => d.FindElement(By.XPath("/html/body/div[2]/div[1]/div[2]/div[1]/a[2]")));
        public IWebElement Title => Wait.Until(d => d.FindElement(By.XPath("//*[@id=\"title\"]")));
        public IWebElement selectTitle => Driver.FindElement(By.XPath("//*[@id=\"title\"]/option[2]"));
        public IWebElement FirstName => Driver.FindElement(By.XPath("//*[@id=\"forename\"]"));
        public IWebElement LastName => Driver.FindElement(By.XPath("//*[@id=\"signupForm\"]/fieldset[1]/input[2]"));
        public IWebElement checkBox => Wait.Until(d => d.FindElement(By.XPath("/html/body/div[2]/div[3]/form/fieldset[5]/input[3]")));
        public IWebElement joinButton =>  Driver.FindElement(By.XPath("//*[@id=\"form\"]"));
        public IWebElement messageForMissedfield => Driver.FindElement(By.XPath("//*[@id=\"signupForm\"]/fieldset[1]/label[7]"));

        public void FillForm()
        {
            joinNow.Click();
            Title.Click();
            selectTitle.Click();
            FirstName.SendKeys("Stelian");
            LastName.SendKeys("Yolov");
            ScrollTo(checkBox).Click();
            joinButton.Click();
        }
    }
}
