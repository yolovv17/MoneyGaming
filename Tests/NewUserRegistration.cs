using GANUIAssignment.RegistrationPage;
using GANUIAssignment.RegistrationPage.BasePages;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace GANUIAssignment.Tests
{
    [TestFixture]
    public class NewUserRegistration : BaseTest
    {
        private object messageForMissedfield;
        private RegistrationFormPage _registrationFormPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://moneygaming.qa.gameaccount.com/");
            _registrationFormPage = new RegistrationFormPage(Driver);

        }

        [Test]
        public void ErrorMessage_Displayed_WithoutDateOFBirth()
        {
            _registrationFormPage.FillForm();
            Assert.AreEqual("This field is required", _registrationFormPage.messageForMissedfield.Text);

        }


        //[TearDown]
        //public void TearDown()
        //{
        //    _driver.Quit();
        //}
    }
}
