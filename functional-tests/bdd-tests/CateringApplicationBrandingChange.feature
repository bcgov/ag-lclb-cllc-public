﻿Feature: CateringApplicationBrandingChange
    As a logged in business user
    I want to pay the first year catering licence fee
    And submit a name branding change for different business types

@e2e @catering @indigenousnation @cateringbranding1
Scenario: Catering Indigenous Nation Branding Change
    Given I am logged in to the dashboard as an indigenous nation
    And I click on the Start Application button for Catering
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Catering application
    And I click on the Submit button
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I click on the Licences tab for Catering
    And I pay the licensing fee for Catering
    And I click on the licence download link
    And I request a valid store name or branding change for Catering
    And the account is deleted
    Then I see the login page

@e2e @catering @partnership @cateringbranding2
Scenario: Catering Partnership Branding Change
    Given I am logged in to the dashboard as a partnership
    And I click on the Start Application button for Catering
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Catering application
    And I click on the Submit button
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I click on the Licences tab for Catering
    And I pay the licensing fee for Catering
    And I click on the licence download link
    And I request a valid store name or branding change for Catering
    And the account is deleted
    Then I see the login page

@e2e @catering @privatecorporation @cateringbranding3
Scenario: Catering Private Corporation Branding Change
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for Catering
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Catering application
    And I click on the Submit button
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I click on the Licences tab for Catering
    And I pay the licensing fee for Catering
    And I click on the licence download link
    And I request a valid store name or branding change for Catering
    And the account is deleted
    Then I see the login page

@e2e @catering @publiccorporation @cateringbranding4
Scenario: Catering Public Corporation Branding Change
    Given I am logged in to the dashboard as a public corporation
    And I click on the Start Application button for Catering
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Catering application
    And I click on the Submit button
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I click on the Licences tab for Catering
    And I pay the licensing fee for Catering
    And I click on the licence download link
    And I request a valid store name or branding change for Catering
    And the account is deleted
    Then I see the login page

@e2e @catering @society @cateringbranding5
Scenario: Catering Society Branding Change
    Given I am logged in to the dashboard as a society
    And I click on the Start Application button for Catering
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Catering application
    And I click on the Submit button
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I click on the Licences tab for Catering
    And I pay the licensing fee for Catering
    And I click on the licence download link
    And I request a valid store name or branding change for Catering
    And the account is deleted
    Then I see the login page

@e2e @catering @soleproprietorship @cateringbranding6
Scenario: Catering Sole Proprietorship Branding Change
    Given I am logged in to the dashboard as a sole proprietorship
    And I click on the Start Application button for Catering
    And I review the account profile
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Catering application
    And I click on the Submit button
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I click on the Licences tab for Catering
    And I pay the licensing fee for Catering
    And I click on the licence download link
    And I request a valid store name or branding change for Catering
    And the account is deleted
    Then I see the login page