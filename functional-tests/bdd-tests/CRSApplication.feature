﻿Feature: CRSApplication.feature
    As a logged in business user
    I want to submit a CRS Application for different business types

@e2e @cannabis @indigenousnation @crsapp2
Scenario: Indigenous Nation CRS Application
    Given I am logged in to the dashboard as an indigenous nation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application
    And I review the security screening requirements
    And I click on the Pay for Application button
    And I enter the payment information
    And I confirm the payment receipt for a Cannabis Retail Store application
    And I return to the dashboard
    And the account is deleted
    Then I see the login page

@e2e @cannabis @partnership @crsapp
Scenario: Partnership CRS Application
    Given I am logged in to the dashboard as a partnership
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application
    And I review the security screening requirements
    And I click on the Pay for Application button
    And I enter the payment information
    And I confirm the payment receipt for a Cannabis Retail Store application
    And I return to the dashboard
    And the account is deleted
    Then I see the login page

@e2e @cannabis @privatecorporation @crsapp
Scenario: Private Corporation CRS Application
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application
    And I review the security screening requirements
    And I click on the Pay for Application button
    And I enter the payment information
    And I confirm the payment receipt for a Cannabis Retail Store application
    And I return to the dashboard
    And the account is deleted
    Then I see the login page

@e2e @cannabis @publiccorporation @crsapp2
Scenario: Public Corporation CRS Application
    Given I am logged in to the dashboard as a public corporation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application
    And I review the security screening requirements
    And I click on the Pay for Application button
    And I enter the payment information
    And I confirm the payment receipt for a Cannabis Retail Store application
    And I return to the dashboard
    And the account is deleted
    Then I see the login page

@e2e @cannabis @society @crsapp2
Scenario: Society CRS Application
    Given I am logged in to the dashboard as a society
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application
    And I review the security screening requirements
    And I click on the Pay for Application button
    And I enter the payment information
    And I confirm the payment receipt for a Cannabis Retail Store application
    And I return to the dashboard
    And the account is deleted
    Then I see the login page

@e2e @cannabis @soleproprietorship @crsapp
Scenario: Sole Proprietorship CRS Application
    Given I am logged in to the dashboard as a sole proprietorship
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application
    And I review the security screening requirements
    And I click on the Pay for Application button
    And I enter the payment information
    And I confirm the payment receipt for a Cannabis Retail Store application
    And I return to the dashboard
    And the account is deleted
    Then I see the login page