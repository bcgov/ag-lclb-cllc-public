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
Feature: ManufacturerStructuralChanges
    As a logged in business user
    I want to request structural alterations to an approved lounge or special events area for a manufacturer licence

@e2e @privatecorporation @manufacturer @winery
Scenario: Winery Structural Alterations to an Approved Lounge or Special Events Area Application
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a winery
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee for a Manufacturer application
    And I request structural alterations to an approved lounge or special events area
    And the account is deleted
    Then I see the login page

@e2e @privatecorporation @manufacturer @winery
Scenario: Brewery Structural Alterations to an Approved Lounge or Special Events Area Application
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a brewery
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee for a Manufacturer application
    And I request structural alterations to an approved lounge or special events area
    And the account is deleted
    Then I see the login page

@e2e @privatecorporation @manufacturer @winery
Scenario: Distillery Structural Alterations to an Approved Lounge or Special Events Area Application
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a distillery
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee for a Manufacturer application
    And I request structural alterations to an approved lounge or special events area
    And the account is deleted
    Then I see the login page

@e2e @privatecorporation @manufacturer @copacker
Scenario: Co-packer Structural Alterations to an Approved Lounge or Special Events Area Application
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a co-packer
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee for a Manufacturer application
    And I request structural alterations to an approved lounge or special events area
    And the account is deleted
    Then I see the login page

@e2e @privatecorporation @manufacturer @validation
Scenario: Validation for Structural Alterations to an Approved Lounge or Special Events Area
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a winery
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee for a Manufacturer application
    And I click on the Licences tab
    And I click on the link for Structural Alterations to an Approved Lounge or Special Events Area
    And I click on the Continue to Application button
    And I do not complete the application correctly
    And the expected validation errors are thrown for a structural alterations request
    And the account is deleted
    Then I see the login page
*/

namespace bdd_tests
{
    [FeatureFile("./ManufacturerStructuralAlterations.feature")]
    [Collection("Liquor")]
    public sealed class ManufacturerStructuralAlterations : TestBase
    {
        [Given(@"I am logged in to the dashboard as a(.*)")]
        public void LogInToDashboard(string businessType)
        {
            NavigateToFeatures();

            CheckFeatureFlagsLiquorTwo();

            CheckFeatureFlagsLicenseeChanges();

            CheckFeatureFlagsSecurityScreening();

            IgnoreSynchronizationFalse();

            CarlaLogin(businessType);
        }
    }
}
