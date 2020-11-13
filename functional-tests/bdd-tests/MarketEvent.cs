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
 Feature: MarketEvent
    As a logged in business user
    I want to submit a market event for different manufacturer types

#-----------------------
# One Market Event
#-----------------------

 @e2e @privatecorporation @marketeventoneday @winery
 Scenario: Winery One Day Market Event
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event for one date only
    And I click on the market event submit button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a one day event
    And the account is deleted
    Then I see the login page

 @e2e @privatecorporation @marketeventoneday @distillery
 Scenario: Distillery One Day Market Event
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event for one date only
    And I click on the market event submit button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a one day event    
    And the account is deleted
    Then I see the login page

 @e2e @privatecorporation @marketeventoneday @brewery
 Scenario: Brewery One Day Market Event
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event for one date only
    And I click on the market event submit button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a one day event
    And the account is deleted
    Then I see the login page

 @e2e @privatecorporation @marketeventoneday @copacker
 Scenario: Co-packer One Day Market Event
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event for one date only
    And I click on the market event submit button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a one day event
    And the account is deleted
    Then I see the login page

#-----------------------
# Weekly Market Event
#-----------------------

 @e2e @privatecorporation @marketeventweekly @winery
 Scenario: Winery Weekly Market Event
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event weekly
    And I click on the market event submit button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a weekly event
    And the account is deleted
    Then I see the login page

 @e2e @privatecorporation @marketeventweekly @distillery
 Scenario: Distillery Weekly Market Event
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event weekly
    And I click on the market event submit button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a weekly event
    And the account is deleted
    Then I see the login page

 @e2e @privatecorporation @marketeventweekly @brewery
 Scenario: Brewery Weekly Market Event
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event weekly
    And I click on the market event submit button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a weekly event
    And the account is deleted
    Then I see the login page

 @e2e @privatecorporation @marketeventweekly @copacker
 Scenario: Co-packer Weekly Market Event
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event weekly
    And I click on the market event submit button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a weekly event
    And the account is deleted
    Then I see the login page

#-------------------------------------------------
# Bi-Weekly Market Event
# Note that 'bi-weekly' refers to twice per month
#-------------------------------------------------

 @e2e @privatecorporation @marketeventbiweekly @winery
 Scenario: Winery Bi-Weekly Market Event
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event bi-weekly
    And I click on the market event submit button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a bi-weekly event
    And the account is deleted
    Then I see the login page

 @e2e @privatecorporation @marketeventbiweekly @distillery
 Scenario: Distillery Bi-Weekly Market Event
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event bi-weekly
    And I click on the market event submit button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a bi-weekly event
    And the account is deleted
    Then I see the login page

 @e2e @privatecorporation @marketeventbiweekly @brewery
 Scenario: Brewery Bi-Weekly Market Event
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event bi-weekly
    And I click on the market event submit button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a bi-weekly event
    And the account is deleted
    Then I see the login page

 @e2e @privatecorporation @marketeventbiweekly @copacker
 Scenario: Co-packer Bi-Weekly Market Event
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event bi-weekly
    And I click on the market event submit button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a bi-weekly event    
    And the account is deleted
    Then I see the login page

#-----------------------
# Monthly Market Event
#-----------------------

 @e2e @privatecorporation @marketeventmonthly @winery
 Scenario: Winery Monthly Market Event
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event monthly
    And I click on the market event submit button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a monthly event
    And the account is deleted
    Then I see the login page

 @e2e @privatecorporation @marketeventmonthly @distillery
 Scenario: Distillery Monthly Market Event
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event monthly
    And I click on the market event submit button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a monthly event
    And the account is deleted
    Then I see the login page

 @e2e @privatecorporation @marketeventmonthly @brewery
 Scenario: Brewery Monthly Market Event
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event monthly
    And I click on the market event submit button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a monthly event
    And the account is deleted
    Then I see the login page

 @e2e @privatecorporation @marketeventmonthly @copacker
 Scenario: Co-packer Monthly Market Event
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event monthly
    And I click on the market event submit button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a monthly event
    And the account is deleted
    Then I see the login page

#-----------------------------------
# One Market Event - Save for Later
#-----------------------------------

 @e2e @privatecorporation @marketeventonedaysave @winery
 Scenario: Winery One Day Market Event Save For Later
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event for one date only
    And I click on the market event save for later button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Draft
    And the market event data is correct for a one day event saved for later
    And I click on the signature checkbox
    And I click on the Submit button
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a one day event
    And the account is deleted
    Then I see the login page

 @e2e @privatecorporation @marketeventonedaysave @distillery
 Scenario: Distillery One Day Market Event Save For Later
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event for one date only
    And I click on the market event save for later button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Draft
    And the market event data is correct for a one day event saved for later  
    And I click on the signature checkbox
    And I click on the Submit button
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a one day event
    And the account is deleted
    Then I see the login page

 @e2e @privatecorporation @marketeventonedaysave @brewery
 Scenario: Brewery One Day Market Event Save For Later
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event for one date only
    And I click on the market event save for later button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Draft
    And the market event data is correct for a one day event saved for later
    And I click on the signature checkbox
    And I click on the Submit button
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a one day event
    And the account is deleted
    Then I see the login page

 @e2e @privatecorporation @marketeventonedaysave @copacker
 Scenario: Co-packer One Day Market Event Save For Later
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event for one date only
    And I click on the market event save for later button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Draft
    And the market event data is correct for a one day event saved for later
    And I click on the signature checkbox
    And I click on the Submit button
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a one day event
    And the account is deleted
    Then I see the login page

#--------------------------------------
# Weekly Market Event - Save for Later
#--------------------------------------

 @e2e @privatecorporation @marketeventweeklysave @winery
 Scenario: Winery Weekly Market Event Save For Later
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event weekly
    And I click on the market event save for later button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Draft
    And the market event data is correct for a weekly event saved for later
    And I click on the signature checkbox
    And I click on the Submit button
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a weekly event
    And the account is deleted
    Then I see the login page

 @e2e @privatecorporation @marketeventweeklysave @distillery
 Scenario: Distillery Weekly Market Event Save For Later
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event weekly
    And I click on the market event save for later button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Draft
    And the market event data is correct for a weekly event saved for later
    And I click on the signature checkbox
    And I click on the Submit button
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a weekly event
    And the account is deleted
    Then I see the login page

 @e2e @privatecorporation @marketeventweeklysave @brewery
 Scenario: Brewery Weekly Market Event Save For Later
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event weekly
    And I click on the market event save for later button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Draft
    And the market event data is correct for a weekly event saved for later
    And I click on the signature checkbox
    And I click on the Submit button
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a weekly event
    And the account is deleted
    Then I see the login page

 @e2e @privatecorporation @marketeventweeklysave @copacker
 Scenario: Co-packer Weekly Market Event Save For Later
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event weekly
    And I click on the market event save for later button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Draft
    And the market event data is correct for a weekly event saved for later
    And I click on the signature checkbox
    And I click on the Submit button
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a weekly event
    And the account is deleted
    Then I see the login page

#-----------------------------------------
# Bi-Weekly Market Event - Save for Later
#-----------------------------------------

 @e2e @privatecorporation @marketeventbiweeklysave @winery
 Scenario: Winery Bi-Weekly Market Event Save For Later
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event bi-weekly
    And I click on the market event save for later button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Draft
    And the market event data is correct for a bi-weekly event saved for later
    And I click on the signature checkbox
    And I click on the Submit button
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a bi-weekly event
    And the account is deleted
    Then I see the login page

 @e2e @privatecorporation @marketeventbiweeklysave @distillery
 Scenario: Distillery Bi-Weekly Market Event Save For Later
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event bi-weekly
    And I click on the market event save for later button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Draft
    And the market event data is correct for a bi-weekly event saved for later
    And I click on the signature checkbox
    And I click on the Submit button
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a bi-weekly event
    And the account is deleted
    Then I see the login page

 @e2e @privatecorporation @marketeventbiweeklysave @brewery
 Scenario: Brewery Bi-Weekly Market Event Save For Later
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event bi-weekly
    And I click on the market event save for later button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Draft
    And the market event data is correct for a bi-weekly event saved for later
    And I click on the signature checkbox
    And I click on the Submit button
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a bi-weekly event
    And the account is deleted
    Then I see the login page

 @e2e @privatecorporation @marketeventbiweeklysave @copacker
 Scenario: Co-packer Bi-Weekly Market Event Save For Later
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event bi-weekly
    And I click on the market event save for later button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Draft
    And the market event data is correct for a bi-weekly event saved for later
    And I click on the signature checkbox
    And I click on the Submit button
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a bi-weekly event
    And the account is deleted
    Then I see the login page

#---------------------------------------
# Monthly Market Event - Save for Later
#---------------------------------------

 @e2e @privatecorporation @marketeventmonthlysave @winery
 Scenario: Winery Monthly Market Event Save For Later
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event monthly
    And I click on the market event save for later button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Draft
    And the market event data is correct for a monthly event saved for later
    And I click on the signature checkbox
    And I click on the Submit button
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a monthly event
    And the account is deleted
    Then I see the login page

 @e2e @privatecorporation @marketeventmonthlysave @distillery
 Scenario: Distillery Monthly Market Event Save For Later
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event monthly
    And I click on the market event save for later button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Draft
    And the market event data is correct for a monthly event saved for later
    And I click on the signature checkbox
    And I click on the Submit button
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a monthly event
    And the account is deleted
    Then I see the login page

 @e2e @privatecorporation @marketeventmonthlysave @brewery
 Scenario: Brewery Monthly Market Event Save For Later
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event monthly
    And I click on the market event save for later button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Draft
    And the market event data is correct for a monthly event saved for later
    And I click on the signature checkbox
    And I click on the Submit button
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a monthly event
    And the account is deleted
    Then I see the login page

 @e2e @privatecorporation @marketeventmonthlysave @copacker
 Scenario: Co-packer Monthly Market Event Save For Later
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
    And I click on the Licences tab
    And I pay the licensing fee for a Manufacturer application
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event monthly
    And I click on the market event save for later button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Draft
    And the market event data is correct for a monthly event saved for later
    And I click on the signature checkbox
    And I click on the Submit button
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a monthly event
    And the account is deleted
    Then I see the login page 
*/

namespace bdd_tests
{
    [FeatureFile("./MarketEvent.feature")]
    [Collection("Liquor")]
    public sealed class MarketEvent : TestBase
    {
        [Given(@"I am logged in to the dashboard as a(.*)")]
        public void LogInToDashboard(string businessType)
        {
            NavigateToFeatures();

            CheckFeatureFlagsLiquorTwo();

            CheckFeatureFlagsLicenseeChanges();

            CheckFeatureFlagsMarketEvents();

            IgnoreSynchronizationFalse();

            CarlaLogin(businessType);
        }
    }
}
