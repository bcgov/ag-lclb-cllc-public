﻿Feature: ManufacturerInvitationForTiedHouseExemption
    As a logged in business user
    I want to submit a tied house exemption for different manufacturer types

Scenario: Manufacturer Tied House Exemption (Winery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I complete the Manufacturer application for a winery
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I click on the link for Licences & Authorizations
    And I pay the licensing fee 
    And I click on the link for Licences & Authorizations
    And I click on the link for Invitation for Tied House Exemption
    And I complete the tied house exemption request
    And I click on the secondary Submit button
    And the account is deleted
    Then I see the login page

Scenario: Manufacturer Tied House Exemption (Brewery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I complete the Manufacturer application for a brewery
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I click on the link for Licences & Authorizations
    And I pay the licensing fee 
    And I click on the link for Licences & Authorizations
    And I click on the link for Invitation for Tied House Exemption
    And I complete the tied house exemption request
    And I click on the secondary Submit button
    And the account is deleted
    Then I see the login page

Scenario: Manufacturer Tied House Exemption (Distillery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I complete the Manufacturer application for a distillery
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I click on the link for Licences & Authorizations
    And I pay the licensing fee 
    And I click on the link for Licences & Authorizations
    And I click on the link for Invitation for Tied House Exemption
    And I complete the tied house exemption request
    And I click on the secondary Submit button
    And the account is deleted
    Then I see the login page

Scenario: Manufacturer Tied House Exemption (Co-packer)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I complete the Manufacturer application for a co-packer
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I click on the link for Licences & Authorizations
    And I pay the licensing fee 
    And I click on the link for Licences & Authorizations
    And I click on the link for Invitation for Tied House Exemption
    And I complete the tied house exemption request
    And I click on the secondary Submit button
    And the account is deleted
    Then I see the login page