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
Feature: CreateMultiLevelCRSApplicationPrivateCorp
    As a logged in business user
    I want to submit a CRS Application for a private corporation
    With multiple nested business shareholders
    To be used as test data

Scenario: Create Multi Level CRS Application Private Corporation
    Given I am logged in to the dashboard as a private corporation
    And the account is deleted
    And I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I add in multiple nested business shareholders
    And I click on the button for Submit Organization Information
    And I complete the Cannabis Retail Store application for a private corporation
    And I click on the button for Pay for Application
    And I enter the payment information
    Then I confirm the payment receipt for a Cannabis Retail Store application
*/

namespace bdd_tests
{
    [FeatureFile("./CreateMultiLevelCRSApplicationPrivateCorp.feature")]
    public sealed class CreateMultiLevelCRSApplicationPrivateCorp : TestBase
    {
        [Given(@"I am logged in to the dashboard as a(.*)")]
        public void LogInToDashboard(string businessType)
        {
            NavigateToFeatures();

            CheckFeatureFlagsLicenseeChanges();

            IgnoreSynchronizationFalse();

            CarlaLoginNoCheck(businessType);
        }
    }
}
