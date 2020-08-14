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
Feature: CRSApplicationLicensingRenewal
    As a logged in business user
    I want to pay the first year licensing fee for an approved CRS Application
    And renew the licence

@e2e @cannabis @privatecorporation @licencerenewal
Scenario: Private Corporation CRS Licence Renewal
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application for a private corporation
    And I click on the Pay for Application button
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee for Cannabis
    And the expiry date is changed to today
    And I renew the licence
    And the account is deleted
    Then I see the login page
*/

namespace bdd_tests
{
    [FeatureFile("./CRSApplicationLicensingRenewal.feature")]
    public sealed class CRSApplicationLicensingRenewal : TestBase
    {
        [Given(@"I am logged in to the dashboard as a(.*)")]
        public void LoggedInToDashboard(string businessType)
        {
            NavigateToFeatures();

            CheckFeatureFlagsLGIN();

            CheckFeatureFlagsIN();

            CheckFeatureFlagsLicenseeChanges();

            CheckFeatureFlagsSecurityScreening();

            IgnoreSynchronization();

            CarlaLogin(businessType);
        }
    }
}
