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
Feature: Director_namechange.feature
    As a logged in business user
    I want to change the name of a director
    And pay the associated fee

Scenario: Change director name and pay fee
    Given I am logged in to the dashboard as a private corporation
    And the account is deleted
    And I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile
    And I review the organization structure
    And I submit the organization structure
    And I complete the Cannabis Retail Store application
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I click on the Licences tab for a Cannabis Retail Store
    And I pay the licensing fee
    And I return to the dashboard
    And I review the organization structure
    And I modify the director name
    And I submit the organization structure
    And I pay the name change fee
    And the director name is now updated
    Then the account is deleted
*/

namespace bdd_tests
{
    [FeatureFile("./Director_namechange.feature")]
    public sealed class DirectorNameChange : TestBase
    {
        [Given(@"I am logged in to the dashboard as a (.*)")]
        public void And_I_view_the_dashboard(string businessType)
        {
            CarlaLogin(businessType);
        }

        [And(@"the account is deleted")]
        public void Delete_my_account()
        {
            this.CarlaDeleteCurrentAccount();
        }

        [And(@"I am logged in to the dashboard as a (.*)")]
        public void And_I_view_the_dashboard2(string businessType)
        {
            CarlaLogin(businessType);
        }

        [And(@"I click on the Start Application button for a Cannabis Retail Store")]
        public void I_start_application()
        {
            /* 
            Page Title: Welcome to Cannabis Licensing
            */

            // click on the Start Application button
            NgWebElement startApp_button = ngDriver.FindElement(By.XPath("//button[text()='START APPLICATION']"));
            startApp_button.Click();
        }

        [And(@"I complete the eligibility disclosure")]
        public void complete_eligibility_disclosure()
        {
            CRSEligibilityDisclosure();
        }

        [And(@"I review the account profile")]
        public void review_account_profile()
        {
            ReviewAccountProfile();
        }

        [And(@"I review the organization structure")]
        public void I_continue_to_organization_review()
        {
            ReviewOrgStructure();
        }

        [And(@"I complete the Cannabis Retail Store application")]
        public void I_complete_the_application()
        {
            CRSApplication();
        }

        [And(@"I click on the Pay for Application button")]
        public void click_on_pay()
        {
            NgWebElement pay_button = ngDriver.FindElement(By.XPath("//button[contains(.,'Pay for Application')]"));
            pay_button.Click();
        }

        [And(@"I enter the payment information")]
        public void enter_payment_info()
        {
            MakePayment();
        }

        [And(@"I return to the dashboard")]
        public void return_to_dashboard()
        {
            // click on Return to Dashboard link
            string retDash = "Return to Dashboard";
            NgWebElement returnDash = ngDriver.FindElement(By.LinkText(retDash));
            returnDash.Click();
        }

        [And(@"I click on the Licences tab for a Cannabis Retail Store")]
        public void click_on_licences_tab()
        {
            /* 
            Page Title: Welcome to Liquor and Cannabis Licensing
            */

            string licencesLink = "Licences";

            // click on the Licences link
            NgWebElement uiLicences = ngDriver.FindElement(By.LinkText(licencesLink));
            uiLicences.Click();
        }

        [And(@"I pay the licensing fee")]
        public void pay_licence_fee()
        {
            /* 
            Page Title: Licences
            Subtitle:   Cannabis Retail Store Licences
            */

            string licenceFee = "Pay Licence Fee and Plan Store Opening";

            // click on the pay licence fee link
            NgWebElement uiLicenceFee = ngDriver.FindElement(By.LinkText(licenceFee));
            uiLicenceFee.Click();

            /* 
            Page Title: Plan Your Store Opening
            */

            string reasonDay = "Automated test: Reason for opening date.";

            // select the opening date
            NgWebElement uiCalendar1 = ngDriver.FindElement(By.XPath("(//input[@type='text'])[3]"));
            uiCalendar1.Click();

            NgWebElement uiCalendar2 = ngDriver.FindElement(By.CssSelector(".mat-calendar-body-cell-content.mat-calendar-body-today"));
            uiCalendar2.Click();

            // enter the reason for the opening date
            NgWebElement uiReasonDate = ngDriver.FindElement(By.XPath("//textarea"));
            uiReasonDate.SendKeys(reasonDay);

            NgWebElement paymentButton = ngDriver.FindElement(By.XPath("//button[contains(.,' PAY LICENCE FEE AND RECEIVE LICENCE')]"));
            paymentButton.Click();

            // pay the licence fee
            MakePayment();

            System.Threading.Thread.Sleep(7000);

            // confirm correct payment amount
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'$1,500.00')]")).Displayed);
        }

        [And(@"I review the organization structure")]
        public void review_org_structure()
        {
            System.Threading.Thread.Sleep(5000);

            // click on the review organization information button
            NgWebElement orgInfoButton = ngDriver.FindElement(By.XPath("//button[contains(.,'REVIEW ORGANIZATION INFORMATION')]"));
            orgInfoButton.Click();
        }

        [And(@"I modify the director name")]
        public void modify_director_name()
        {
            // click on the Edit button for Key Personnel
            NgWebElement uiEditInfoButton = ngDriver.FindElement(By.XPath("//i/span"));
            uiEditInfoButton.Click();

            // enter a new name for the director
            string newDirectorFirstName = "Updated Director";

            NgWebElement uiNewDirectorFirstName = ngDriver.FindElement(By.XPath("//input[@type='text']"));
            uiNewDirectorFirstName.Clear();
            uiNewDirectorFirstName.SendKeys(newDirectorFirstName);

            // click on the Confirm button
            NgWebElement uiConfirmButton = ngDriver.FindElement(By.XPath("//i/span"));
            uiConfirmButton.Click();

            // find the upload test file in the bdd-tests\upload_files folder
            var environment = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(environment).Parent.FullName;
            string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;

            // upload a marriage certificate document
            string marriageCertificate = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "marriage_certificate.pdf");
            NgWebElement uploadMarriageCert = ngDriver.FindElement(By.XPath("(//input[@type='file'])[12]"));
            uploadMarriageCert.SendKeys(marriageCertificate);
        }

        [And(@"I submit the organization structure")]
        public void submit_org_structure()
        {
            // click on submit org info button
            NgWebElement orgInfoButton = ngDriver.FindElement(By.XPath("//button[contains(.,' SUBMIT ORGANIZATION INFORMATION')]"));
            orgInfoButton.Click();
        }

        [And(@"I pay the name change fee")]
        public void name_change_fee()
        {
            MakePayment();

            // check payment fee
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'$500.00')]")).Displayed);
        }

        [And(@"the director name is now updated")]
        public void director_name_updated()
        {
            System.Threading.Thread.Sleep(7000);

            this.return_to_dashboard();

            this.review_org_structure();

            System.Threading.Thread.Sleep(7000);

            // check that the director name has been updated
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Updated Director')]")).Displayed);
        }

        [Then(@"the account is deleted")]
        public void Delete_my_account2()
        {
            this.CarlaDeleteCurrentAccount();
        }
    }
}
