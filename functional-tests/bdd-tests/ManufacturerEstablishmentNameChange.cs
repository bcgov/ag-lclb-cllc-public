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
Feature: ManufacturerEstablishmentNameChange
    As a logged in business user
    I want to request a valid store name or branding change for a manufacturer licence

@manufacturer @winery @namechange
Scenario: UAT Establishment Name Change Application (Winery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a winery
    And I review the security screening requirements for a private corporation
    And I click on the button for Pay for Application
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee
    And I request a valid store name or branding change for Manufacturing
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the account is deleted
    Then I see the login page

@manufacturer @brewery @namechange
Scenario: UAT Establishment Name Change Application (Brewery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a brewery
    And I review the security screening requirements for a private corporation
    And I click on the button for Pay for Application
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee
    And I request a valid store name or branding change for Manufacturing
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the account is deleted
    Then I see the login page

@manufacturer @distillery @namechange
Scenario: UAT Establishment Name Change Application (Distillery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a distillery
    And I review the security screening requirements for a private corporation
    And I click on the button for Pay for Application
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee
    And I request a valid store name or branding change for Manufacturing
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the account is deleted
    Then I see the login page

@manufacturer @copacker @namechange
Scenario: UAT Establishment Name Change Application (Co-packer)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a co-packer
    And I review the security screening requirements for a private corporation
    And I click on the button for Pay for Application
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee
    And I request a valid store name or branding change for Manufacturing
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the account is deleted
    Then I see the login page

@manufacturer @winery @namechange
Scenario: DEV Establishment Name Change Application (Winery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I complete the Manufacturer application for a winery
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee
    And I request a valid store name or branding change for Manufacturing
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the account is deleted
    Then I see the login page

@manufacturer @brewery @namechange
Scenario: DEV Establishment Name Change Application (Brewery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I complete the Manufacturer application for a brewery
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee
    And I request a valid store name or branding change for Manufacturing
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the account is deleted
    Then I see the login page

@manufacturer @distillery @namechange
Scenario: DEV Establishment Name Change Application (Distillery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I complete the Manufacturer application for a distillery
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee
    And I request a valid store name or branding change for Manufacturing
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the account is deleted
    Then I see the login page

@manufacturer @copacker @namechange
Scenario: DEV Establishment Name Change Application (Co-packer)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I complete the Manufacturer application for a co-packer
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee
    And I request a valid store name or branding change for Manufacturing
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the account is deleted
    Then I see the login page
*/

namespace bdd_tests
{
    [FeatureFile("./ManufacturerEstablishmentNameChange.feature")]
    [Collection("Liquor")]
    public sealed class ManufacturerEstablishmentNameChange : TestBase
    {
        [Given(@"I am logged in to the dashboard as a(.*)")]
        public void LogInToDashboard(string businessType)
        {
            NavigateToFeatures();

            CheckFeatureFlagsLiquorTwo();

            CheckFeatureFlagsLicenseeChanges();

            CheckFeatureFlagsSecurityScreening();

            // CheckFeatureLEConnections();

            IgnoreSynchronizationFalse();

            CarlaLogin(businessType);
        }
    }
}
