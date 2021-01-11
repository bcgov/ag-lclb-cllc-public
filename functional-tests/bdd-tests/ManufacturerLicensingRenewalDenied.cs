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
Feature: ManufacturerLicensingRenewalDenied
    As a logged in business user
    I want to pay the first year licensing fee for an approved Manucturer Application
    And confirm that autorenewal is set to 'No' to prevent renewal of the licence

#-----------------------
# Expiry = Today
#-----------------------

@manufacturer @licencerenewal
Scenario:  Deny Today Licence Renewal (Winery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a winery
    And I click on the button for Pay for Application
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee 
    And I click on the Licences tab
    # Note: The following workflow sets the Dynamics autorenewal flag to 'No'
    And the expiry date is changed using the Dynamics workflow named 322d410b-f725-eb11-b821-00505683fbf4
    And I am unable to renew the licence
    And the account is deleted
    Then I see the login page

@manufacturer @licencerenewal
Scenario:  Deny Today Licence Renewal (Brewery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a brewery
    And I click on the button for Pay for Application
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee 
    And I click on the Licences tab
    # Note: The following workflow sets the Dynamics autorenewal flag to 'No'
    And the expiry date is changed using the Dynamics workflow named 322d410b-f725-eb11-b821-00505683fbf4
    And I am unable to renew the licence
    And the account is deleted
    Then I see the login page

@manufacturer @licencerenewal
Scenario:  Deny Today Licence Renewal (Distillery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a distillery
    And I click on the button for Pay for Application
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee 
    And I click on the Licences tab
    # Note: The following workflow sets the Dynamics autorenewal flag to 'No'
    And the expiry date is changed using the Dynamics workflow named 322d410b-f725-eb11-b821-00505683fbf4
    And I am unable to renew the licence
    And the account is deleted
    Then I see the login page

@manufacturer @licencerenewal
Scenario:  Deny Today Licence Renewal (Co-packer)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a co-packer
    And I click on the button for Pay for Application
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee 
    And I click on the Licences tab
    # Note: The following workflow sets the Dynamics autorenewal flag to 'No'
    And the expiry date is changed using the Dynamics workflow named 322d410b-f725-eb11-b821-00505683fbf4
    And I am unable to renew the licence
    And the account is deleted
    Then I see the login page

#-----------------------
# Expiry = Yesterday
#-----------------------

@manufacturer @licencerenewal
Scenario:  Deny Yesterday Licence Renewal (Winery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a winery
    And I click on the button for Pay for Application
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee 
    And I click on the Licences tab
    # Note: The following workflow sets the Dynamics autorenewal flag to 'No'
    And the expiry date is changed using the Dynamics workflow named e1792ccf-e40b-491f-9a9a-ee8e977749e6
    And I am unable to renew the licence
    And the account is deleted
    Then I see the login page

@manufacturer @licencerenewal
Scenario:  Deny Yesterday Licence Renewal (Brewery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a brewery
    And I click on the button for Pay for Application
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee
    And I click on the Licences tab
    # Note: The following workflow sets the Dynamics autorenewal flag to 'No'
    And the expiry date is changed using the Dynamics workflow named e1792ccf-e40b-491f-9a9a-ee8e977749e6
    And I am unable to renew the licence
    And the account is deleted
    Then I see the login page

@manufacturer @licencerenewal
Scenario:  Deny Yesterday Licence Renewal (Distillery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a distillery
    And I click on the button for Pay for Application
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee 
    And I click on the Licences tab
    # Note: The following workflow sets the Dynamics autorenewal flag to 'No'
    And the expiry date is changed using the Dynamics workflow named e1792ccf-e40b-491f-9a9a-ee8e977749e6
    And I am unable to renew the licence
    And the account is deleted
    Then I see the login page

@manufacturer @licencerenewal
Scenario:  Deny Yesterday Licence Renewal (Co-packer)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a co-packer
    And I click on the button for Pay for Application
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee 
    And I click on the Licences tab
    # Note: The following workflow sets the Dynamics autorenewal flag to 'No'
    And the expiry date is changed using the Dynamics workflow named e1792ccf-e40b-491f-9a9a-ee8e977749e6
    And I am unable to renew the licence
    And the account is deleted
    Then I see the login page

#-----------------------
# Expiry = 45 Days Ago
#-----------------------

@manufacturer @licencerenewal
Scenario:  Deny 45 Days Ago Licence Renewal (Winery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a winery
    And I click on the button for Pay for Application
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee 
    And I click on the Licences tab
    # Note: The following workflow sets the Dynamics autorenewal flag to 'No'
    And the expiry date is changed using the Dynamics workflow named 65bfe79d-f825-eb11-b821-00505683fbf4
    And I am unable to renew the licence
    And the account is deleted
    Then I see the login page

@manufacturer @licencerenewal
Scenario:  Deny 45 Days Ago Licence Renewal (Brewery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a brewery
    And I click on the button for Pay for Application
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee 
    And I click on the Licences tab
    # Note: The following workflow sets the Dynamics autorenewal flag to 'No'
    And the expiry date is changed using the Dynamics workflow named 65bfe79d-f825-eb11-b821-00505683fbf4
    And I am unable to renew the licence
    And the account is deleted
    Then I see the login page

@manufacturer @licencerenewal
Scenario:  Deny 45 Days Ago Licence Renewal (Distillery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a distillery
    And I click on the button for Pay for Application
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee 
    And I click on the Licences tab
    # Note: The following workflow sets the Dynamics autorenewal flag to 'No'
    And the expiry date is changed using the Dynamics workflow named 65bfe79d-f825-eb11-b821-00505683fbf4
    And I am unable to renew the licence
    And the account is deleted
    Then I see the login page

@manufacturer @licencerenewal
Scenario:  Deny 45 Days Ago Licence Renewal (Co-packer)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a co-packer
    And I click on the button for Pay for Application
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee 
    And I click on the Licences tab
    # Note: The following workflow sets the Dynamics autorenewal flag to 'No'
    And the expiry date is changed using the Dynamics workflow named 65bfe79d-f825-eb11-b821-00505683fbf4
    And I am unable to renew the licence
    And the account is deleted
    Then I see the login page

#-----------------------------
# Expiry = 60 Days From Today
#-----------------------------

@manufacturer @licencerenewal
Scenario:  Deny 60 Days From Today Licence Renewal (Winery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a winery
    And I click on the button for Pay for Application
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee 
    And I click on the Licences tab
    # Note: The following workflow sets the Dynamics autorenewal flag to 'No'
    And the expiry date is changed using the Dynamics workflow named beb3243e-f825-eb11-b821-00505683fbf4
    And I am unable to renew the licence
    And the account is deleted
    Then I see the login page

@manufacturer @licencerenewal
Scenario:  Deny 60 Days From Today Licence Renewal (Brewery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a brewery
    And I click on the button for Pay for Application
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee 
    And I click on the Licences tab
    # Note: The following workflow sets the Dynamics autorenewal flag to 'No'
    And the expiry date is changed using the Dynamics workflow named beb3243e-f825-eb11-b821-00505683fbf4
    And I am unable to renew the licence
    And the account is deleted
    Then I see the login page

@manufacturer @licencerenewal
Scenario:  Deny 60 Days From Today Licence Renewal (Distillery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a distillery
    And I click on the button for Pay for Application
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee 
    And I click on the Licences tab
    # Note: The following workflow sets the Dynamics autorenewal flag to 'No'
    And the expiry date is changed using the Dynamics workflow named beb3243e-f825-eb11-b821-00505683fbf4
    And I am unable to renew the licence
    And the account is deleted
    Then I see the login page

@manufacturer @licencerenewal
Scenario:  Deny 60 Days From Today Licence Renewal (Co-packer)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a co-packer
    And I click on the button for Pay for Application
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee
    And I click on the Licences tab
    # Note: The following workflow sets the Dynamics autorenewal flag to 'No'
    And the expiry date is changed using the Dynamics workflow named beb3243e-f825-eb11-b821-00505683fbf4
    And I am unable to renew the licence
    And the account is deleted
    Then I see the login page

#-----------------------------
# Expiry = 30 Days From Today
#-----------------------------

@manufacturer @licencerenewal
Scenario:  Deny 30 Days From Today Licence Renewal (Winery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a winery
    And I click on the button for Pay for Application
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee 
    And I click on the Licences tab
    # Note: The following workflow sets the Dynamics autorenewal flag to 'No'
    And the expiry date is changed using the Dynamics workflow named 10eaae77-f725-eb11-b821-00505683fbf4
    And I am unable to renew the licence
    And the account is deleted
    Then I see the login page

@manufacturer @licencerenewal
Scenario:  Deny 30 Days From Today Licence Renewal (Brewery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a brewery
    And I click on the button for Pay for Application
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee
    And I click on the Licences tab
    # Note: The following workflow sets the Dynamics autorenewal flag to 'No'
    And the expiry date is changed using the Dynamics workflow named 10eaae77-f725-eb11-b821-00505683fbf4
    And I am unable to renew the licence
    And the account is deleted
    Then I see the login page

@manufacturer @licencerenewal
Scenario:  Deny 30 Days From Today Licence Renewal (Distillery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a distillery
    And I click on the button for Pay for Application
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee 
    And I click on the Licences tab
    # Note: The following workflow sets the Dynamics autorenewal flag to 'No'
    And the expiry date is changed using the Dynamics workflow named 10eaae77-f725-eb11-b821-00505683fbf4
    And I am unable to renew the licence
    And the account is deleted
    Then I see the login page

@manufacturer @licencerenewal
Scenario:  Deny 30 Days From Today Licence Renewal (Co-packer)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Manufacturer application for a co-packer
    And I click on the button for Pay for Application
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee 
    And I click on the Licences tab
    # Note: The following workflow sets the Dynamics autorenewal flag to 'No'
    And the expiry date is changed using the Dynamics workflow named 10eaae77-f725-eb11-b821-00505683fbf4
    And I am unable to renew the licence
    And the account is deleted
    Then I see the login page
*/

namespace bdd_tests
{
    [FeatureFile("./ManufacturerLicensingRenewalDenied.feature")]
    [Collection("Liquor")]
    public sealed class ManufacturerLicensingRenewalDenied : TestBase
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
