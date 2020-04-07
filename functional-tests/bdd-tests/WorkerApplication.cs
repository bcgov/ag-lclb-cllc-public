﻿using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using Protractor;
using System;
using Xunit.Gherkin.Quick;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.IO;
using Xunit;

/*
Feature: WorkerApplication
    As a logged in worker applicant
    I want to submit a cannabis worker application

Scenario: Worker Application
    Given I am logged in to the dashboard
    And I click on my name
    And I complete Step 1 of the application
    And I complete Step 2 of the application
    And I click on the Submit & Pay button
    And I enter the payment information
    And I return to the dashboard
    Then the dashboard has a new status
*/

namespace bdd_tests
{
    [FeatureFile("./WorkerApplication.feature")]
    public sealed class WorkerApplication : TestBaseWorker
    {

        [Given(@"I login with no terms")]
        public void I_login_no_terms()
        {
            CarlaLoginWorkerNoTerms();
        }

        [Given(@"I am logged in to the dashboard")]
        public void I_view_the_dashboard()
        {
            CarlaLoginWorker();
        }

        [And(@"I am logged in to the dashboard")]
        public void And_I_view_the_dashboard()
        {
            CarlaLoginWorker();
        }

        [And(@"I click on my name")]
        public void I_click_on_my_name()
        {
            /* 
            Page Title: Worker Dashboard
            */

            NgWebElement uiNameLink = ngDriver.FindElement(By.XPath("//a[contains(text(),'Associate')]"));
            uiNameLink.Click();
        }

        [And(@"I complete Step 1 of the application")]
        public void I_complete_step_1_of_the_application()
        {
            /* 
            Page Title: Worker Security Verification Application - Step 1
            */

            string birthCityCountry = "Victoria, Canada";
            string BCDL = "1234568";
            string BCID = "123456789";
            string primaryPhone = "2508888888";
            string email = "test@automation.com";
            string mailingStreet = "645 Tyee Road";
            string mailingCity = "Victoria";
            string mailingProvince = "BC";
            string postalCode = "V8V4Y3";

            // enter the birth city and country
            NgWebElement uiBirthCityCountry = ngDriver.FindElement(By.XPath("(//input[@type='text'])[4]"));
            uiBirthCityCountry.SendKeys(birthCityCountry);

            // enter the BC driver's licence
            NgWebElement uiBCDL = ngDriver.FindElement(By.XPath("(//input[@type='text'])[7]"));
            uiBCDL.SendKeys(BCDL);

            // enter the BCID
            NgWebElement uiBCID = ngDriver.FindElement(By.XPath("(//input[@type='text'])[8]"));
            uiBCID.SendKeys(BCID);

            // enter the primary phone number
            NgWebElement uiPrimaryPhone = ngDriver.FindElement(By.XPath("(//input[@type='text'])[9]"));
            uiPrimaryPhone.SendKeys(primaryPhone);

            // enter the email address
            NgWebElement uiEmail = ngDriver.FindElement(By.XPath("//input[@type='email']"));
            uiEmail.SendKeys(email);

            // select the start date (Date: From) for the current address
            NgWebElement openCalendar = ngDriver.FindElement(By.XPath("(//input[@type='text'])[15]"));
            openCalendar.Click();

            NgWebElement nextCalendar = ngDriver.FindElement(By.XPath("//mat-calendar[@id='mat-datepicker-0']/mat-calendar-header/div/div/button/span"));
            nextCalendar.Click();

            NgWebElement nextCalendar2 = ngDriver.FindElement(By.XPath("//mat-calendar[@id='mat-datepicker-0']/div/mat-multi-year-view/table/tbody/tr[4]/td[2]/div"));
            nextCalendar2.Click();

            NgWebElement nextCalendar3 = ngDriver.FindElement(By.XPath("//mat-calendar[@id='mat-datepicker-0']/div/mat-year-view/table/tbody/tr[3]/td[4]/div"));
            nextCalendar3.Click();

            NgWebElement nextCalendar4 = ngDriver.FindElement(By.XPath("//mat-calendar[@id='mat-datepicker-0']/div/mat-month-view/table/tbody/tr[4]/td[4]/div"));
            nextCalendar4.Click();

            // enter the street of the mailing address
            NgWebElement uiMailingStreet = ngDriver.FindElement(By.XPath("(//input[@type='text'])[17]"));
            uiMailingStreet.SendKeys(mailingStreet);

            // enter the city of the mailing address
            NgWebElement uiMailingCity = ngDriver.FindElement(By.XPath("(//input[@type='text'])[18]"));
            uiMailingCity.SendKeys(mailingCity);

            // enter the province of the mailing address
            NgWebElement uiMailingProvince = ngDriver.FindElement(By.XPath("(//input[@type='text'])[19]"));
            uiMailingProvince.SendKeys(mailingProvince);

            // enter the postal code of the mailing address
            NgWebElement uiPostalCode = ngDriver.FindElement(By.XPath("(//input[@type='text'])[20]"));
            uiPostalCode.SendKeys(postalCode);

            // click on save and continue button
            NgWebElement saveAndContinueButton = ngDriver.FindElement(By.XPath("//button[contains(.,'SAVE & CONTINUE TO STEP 2')]"));
            saveAndContinueButton.Click();
        }

        [And(@"I complete Step 2 of the application")]
        public void I_complete_step_2_of_the_application()
        {
            /* 
            Page Title: Consent for Cannabis Security Screening - Step 2
            */

            //string applicantName = "Automated Test";
            
            // select 'No' for background screen (self disclosure) radio button
            NgWebElement uiSelfDisclosure = ngDriver.FindElement(By.XPath("(//input[@name='selfDisclosure'])[2]"));
            uiSelfDisclosure.Click();

            // select consent and disclosure checkbox
            NgWebElement uiNoWetSignature1 = ngDriver.FindElement(By.XPath("//input[@type='checkbox']"));
            uiNoWetSignature1.Click();

            // select signature checkbox
            //NgWebElement uiNoWetSignature2 = ngDriver.FindElement(By.XPath("(//input[@type='checkbox'])[2]"));
            //uiNoWetSignature2.Click();

            // enter applicant name
            //NgWebElement uiApplicantName = ngDriver.FindElement(By.XPath("//input[@type='text']"));
            //uiApplicantName.SendKeys(applicantName);

            // upload the signature form
            //var environment = Environment.CurrentDirectory;
            //string projectDirectory = Directory.GetParent(environment).Parent.FullName;
            //string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;

            //string signatureFormPath = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "signature.pdf");
            //NgWebElement uploadSignatureForm = ngDriver.FindElement(By.XPath("(//input[@type='file'])[3]"));
            //uploadSignatureForm.SendKeys(signatureFormPath);
        }

        [And(@"I click on the Submit & Pay button")]
        public void click_on_submit_and_pay()
        {
            /* 
            Page Title: Consent for Cannabis Security Screening - Step 2
            */

            // click on the Submit and Pay button
            NgWebElement submitpay_button = ngDriver.FindElement(By.XPath("//button[contains(.,'SUBMIT & PAY')]"));
            System.Threading.Thread.Sleep(7000);

            submitpay_button.Click();
            System.Threading.Thread.Sleep(7000);
        }

        [And(@"I enter the payment information")]
        public void enter_payment_info()
        {
            /* 
            Page Title: Internet Payments Program (Bambora)
            */

            MakeWorkerPayment();
        }

        [And(@"I return to the dashboard")]
        public void return_to_dashboard()
        {
            /* 
            Page Title: Payment Approved
            */

            string retDash = "Return to Dashboard";

            // confirm that payment receipt is for $100.00
            Assert.True (ngDriver.FindElement(By.XPath("/html/body/app-root/div/div/div/main/div/app-worker-payment-confirmation/mat-card/div/div[1]/div/div/table/tr[5]/td[2][text()='$100.00']")).Displayed);

            // click on the Return to Dashboard link
            NgWebElement returnDash = ngDriver.FindElement(By.LinkText(retDash));
            returnDash.Click();
        }

        [And(@"the dashboard has a new status")]
        public void dashboard_has_new_status()
        {
            /* 
            Page Title: Worker Dashboard
            */

            // confirm Security Verification Status: Pending Review status is displayed
            Assert.True (ngDriver.FindElement(By.XPath("/html/body/app-root/div/div/div/main/div/app-dashboard/div/div[2]/div[1]/div/section/div/h2[text()='Security Verification Status: Pending Review']")).Displayed);
        }

        [And(@"the account is deleted")]
        public void Delete_my_account()
        {
            this.CarlaDeleteCurrentAccount();
        }

        [Then(@"I sign out")]
        public void sign_out()
        {
            CarlaDeleteCurrentAccount();
        }

        [Then(@"I see the login page")]
        public void I_see_login()
        {
            /* 
            Page Title: Apply for a cannabis licence
            */

            Assert.True(ngDriver.FindElement(By.XPath("//a[text()='Log In']")).Displayed);
        }
    }
}
