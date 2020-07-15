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
Feature: Create_CRSApplication_indigenousnation
    As a logged in business user
    I want to submit a CRS Application for an indigenous nation
    To be used as test data

Scenario: Start Application
    Given I am logged in to the dashboard as an indigenous nation
    And the account is deleted
    And I am logged in to the dashboard as an indigenous nation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile for a indigenous nation
    And I review the organization structure for a indigenous nation
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application for a indigenous nation
    And I click on the Pay for Application button
    And I enter the payment information
    Then I return to the dashboard   
*/

namespace bdd_tests
{
    [FeatureFile("./Create_CRSApplication_indigenousnation.feature")]
    public sealed class CreateCRSApplicationIndigenousNation : TestBase
    {
        [Given(@"I am logged in to the dashboard as an (.*)")]
        public void I_view_the_dashboard(string businessType)
        {
            CarlaLoginNoCheck();
        }

        [And(@"I am logged in to the dashboard as an (.*)")]
        public void And_I_view_the_dashboard_IN(string businessType)
        {
            CarlaLoginWithUser(businessType);
        }
    }
}
