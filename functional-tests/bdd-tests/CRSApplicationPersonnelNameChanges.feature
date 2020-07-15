﻿Feature: CRSApplicationPersonnelNameChanges
    As a logged in business user
    I want to submit a CRS Application for different business types
    And request personnel email and name changes for the approved application

@e2e @cannabis @partnership @crsemail
Scenario: Partnership Personnel Name Changes
    Given I am logged in to the dashboard as a partnership
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I pay the licensing fee for Cannabis
    # And I change a personnel email address
    And I request a personnel name change
    And the account is deleted
    Then I see the login page

@e2e @cannabis @privatecorporation @crsemail
Scenario: Private Corporation Personnel Name Changes
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I pay the licensing fee for Cannabis
    # And I change a personnel email address
    And I request a personnel name change
    And the account is deleted
    Then I see the login page

@e2e @cannabis @publiccorporation @crsemailpubcorp
Scenario: Public Corporation Personnel Name Changes
    Given I am logged in to the dashboard as a public corporation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I pay the licensing fee for Cannabis
    # And I change a personnel email address
    And I request a personnel name change
    And the account is deleted
    Then I see the login page

@e2e @cannabis @society @crsemail2
Scenario: Society Personnel Name Changes
    Given I am logged in to the dashboard as a society
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I pay the licensing fee for Cannabis
    # And I change a personnel email address
    And I request a personnel name change
    And the account is deleted
    Then I see the login page

@e2e @cannabis @soleproprietorship @crsemail
Scenario: Sole Proprietorship Personnel Name Changes
    Given I am logged in to the dashboard as a sole proprietorship
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I pay the licensing fee for Cannabis
    # And I change a personnel email address
    And I request a personnel name change
    And the account is deleted
    Then I see the login page