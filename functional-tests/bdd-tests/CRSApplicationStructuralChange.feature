﻿Feature: CRSApplicationStructuralChange
    As a logged in business user
    I want to submit a CRS Application for different business types
    And request a structural change for the approved application

@cannabis @indigenousnation @crsstructuralchanges
Scenario: Cannabis Structural Changes (Indigenous Nation)
    Given I am logged in to the dashboard as an indigenous nation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile for an indigenous nation
    And I review the organization structure for an indigenous nation
    And I click on the button for Submit Organization Information
    And I complete the Cannabis Retail Store application for an indigenous nation
    And I click on the button for Pay for Application
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee
    And I request a structural change
    And I click on the link for Dashboard
    And I confirm the structural change request is displayed on the dashboard
    And the account is deleted
    Then I see the login page

@cannabis @partnership @crsstructuralchanges
Scenario: Cannabis Structural Changes (Partnership)
    Given I am logged in to the dashboard as a partnership
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile for a partnership
    And I review the organization structure for a partnership
    And I click on the button for Submit Organization Information
    And I complete the Cannabis Retail Store application for a partnership
    And I click on the button for Pay for Application
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee
    And I request a structural change
    And I click on the link for Dashboard
    And I confirm the structural change request is displayed on the dashboard
    And the account is deleted
    Then I see the login page

@cannabis @privatecorporation @crsstructuralchanges
Scenario: Cannabis Structural Changes (Private Corporation)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Cannabis Retail Store application for a private corporation
    And I click on the button for Pay for Application
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee
    And I request a structural change
    And I click on the link for Dashboard
    And I confirm the structural change request is displayed on the dashboard
    And the account is deleted
    Then I see the login page

@cannabis @publiccorporation @crsstructuralchanges
Scenario: Cannabis Structural Changes (Public Corporation)
    Given I am logged in to the dashboard as a public corporation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile for a public corporation
    And I review the organization structure for a public corporation
    And I click on the button for Submit Organization Information
    And I complete the Cannabis Retail Store application for a public corporation
    And I click on the button for Pay for Application
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee
    And I request a structural change
    And I click on the link for Dashboard
    And I confirm the structural change request is displayed on the dashboard
    And the account is deleted
    Then I see the login page

@cannabis @society @crsstructuralchanges
Scenario: Cannabis Structural Changes (Society)
    Given I am logged in to the dashboard as a society
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile for a society
    And I review the organization structure for a society
    And I click on the button for Submit Organization Information
    And I complete the Cannabis Retail Store application for a society
    And I click on the button for Pay for Application
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee
    And I request a structural change
    And I click on the link for Dashboard
    And I confirm the structural change request is displayed on the dashboard
    And the account is deleted
    Then I see the login page

@cannabis @soleproprietorship @crsstructuralchanges
Scenario: Cannabis Structural Changes (Sole Proprietorship)
    Given I am logged in to the dashboard as a sole proprietorship
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile for a sole proprietorship
    And I review the organization structure for a sole proprietorship
    And I click on the button for Submit Organization Information
    And I complete the Cannabis Retail Store application for a sole proprietorship
    And I click on the button for Pay for Application
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee
    And I request a structural change
    And I click on the link for Dashboard
    And I confirm the structural change request is displayed on the dashboard
    And the account is deleted
    Then I see the login page