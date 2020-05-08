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
Feature: CateringApplication_soleproprietor
    As a logged in business user
    I want to submit a Catering Application for a sole proprietor

Scenario: Start Application
    Given I am logged in to the dashboard as a sole proprietorship
    And the account is deleted
    And I am logged in to the dashboard as a sole proprietorship
    And I click on the Start Application button for Catering
    And I review the account profile
    And I review the organization structure
    And I submit the organization structure
    And I complete the Catering application
    And I click on the Submit button
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the account is deleted
    Then I see the login page
*/

namespace bdd_tests
{
    [FeatureFile("./CateringApplication_soleproprietor.feature")]
    public sealed class CateringApplicationSoleProprietor : TestBase
    {
        public void CheckFeatureFlagsLiquor()
        {
            // navigate to the feature flags page
            driver.Navigate().GoToUrl($"{baseUri}api/features");

            // confirm that the LiquorOne flag is enabled during this test
            Assert.True(driver.FindElement(By.XPath("//body[contains(.,'LiquorOne')]")).Displayed);
        }

        [Given(@"I am logged in to the dashboard as a (.*)")]
        public void I_view_the_dashboard(string businessType)
        {
            CheckFeatureFlagsLiquor();

            CarlaLoginNoCheck();
        }

        [And(@"I am logged in to the dashboard as a (.*)")]
        public void And_I_view_the_dashboard(string businessType)
        {
            CarlaLogin(businessType);
        }

        [And(@"I click on the Start Application button for (.*)")]
        public void I_start_application(string application_type)
        {

            // click on the Catering Start Application button
            NgWebElement startApp_button = ngDriver.FindElement(By.Id("startCatering"));
            startApp_button.Click();

            applicationTypeShared = application_type;
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

        [And(@"I submit the organization structure")]
        public void submit_org_structure()
        {
            SubmitOrgInfoButton();
        }

        [And(@"I complete the Catering application")]
        public void I_complete_the_application()
        {
            CateringApplication();
        }

        [And(@"I click on the Submit button")]
        public void click_on_submit()
        {
            NgWebElement submit_button = ngDriver.FindElement(By.XPath("//button[contains(.,'SUBMIT')]"));
            submit_button.Click();
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
            CateringReturnToDashboard();
        }

        [And(@"the account is deleted")]
        public void Delete_my_account()
        {
            this.CarlaDeleteCurrentAccount();
        }

        [Then(@"I see the login page")]
        public void I_see_login()
        {
            /* 
            Page Title: 
            */

            Assert.True(ngDriver.FindElement(By.XPath("//a[text()='Log In']")).Displayed);
        }
    }
}