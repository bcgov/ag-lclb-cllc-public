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
Feature: CRS_request_store_name_branding_change
    As a logged in business user
    I would like to request a Cannabis Retail Store name or branding change

Scenario: Request CRS Store Name or Branding Change
    Given the CRS application has been approved
    And I am logged in to the dashboard as a private corporation
    And I click on the Licences tab
    And the licence fee has been paid
    And I click on the Request Store Name or Branding Change link
    And I review the account profile
    And I submit a valid name or branding change application
    And I complete the payment
    And I return to the dashboard
    Then a name or branding change application under review is displayed
*/

namespace bdd_tests
{
    [FeatureFile("./CRS_request_store_name_branding_change.feature")]
    public sealed class CRSRequestStoreNameBrandingChange : TestBase
    {

        [Given(@"the CRS application has been approved")]
        public void CRS_application_is_approved()
        {
        }

        //[Given(@"I am logged in to the dashboard as a (.*)")]
        [And(@"I am logged in to the dashboard as a (.*)")]
        public void And_I_view_the_dashboard(string businessType)
        {
            CarlaLogin(businessType);
        }

        [And(@"I click on the Licences tab")]
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

        [And(@"the licence fee has been paid")]
        public void licence_fee_paid()
        {
            /* 
            Page Title: 
            */
        }

        [And(@"I click on the Request Store Name or Branding Change link")]
        public void request_store_name_branding_change()
        {
            /* 
            Page Title: Licences
            Subtitle:   Cannabis Retail Store Licences
            */
        }

        [And(@"I review the account profile")]
        public void review_account_profile()
        {
            /* 
            Page Title:
            */
        }

        [And(@"I submit a valid name or branding change application")]
        public void submit_valid_name_branding_change()
        {
            /* 
            Page Title:
            */
        }

        [And(@"I complete the payment")]
        public void complete_the_payment()
        {
            MakePayment();
        }

        [And(@"I return to the dashboard")]
        public void return_to_dashboard()
        {
            /* 
            Page Title: Payment Approved
            */

            string retDash = "Return to Dashboard";

            // click on the Return to Dashboard link
            NgWebElement returnDash = ngDriver.FindElement(By.LinkText(retDash));
            returnDash.Click();
        }

        [Then(@"a name or branding change application under review is displayed")]
        public void name_branding_application_displayed()
        {
            /* 
            Page Title: Licences
            Subtitle:   Cannabis Retail Store Licences
            */

            //Assert.True (ngDriver.FindElement(By.XPath("//a[text()='Log In']")).Displayed);
        }
    }
}
