﻿Feature: CateringApplicationStoreRelocationThirdParty
    As a logged in business user
    I want to pay the first year catering licence fee
    And submit a store relocation and third party operator request for different business types

@e2e @catering @indigenousnation @cateringrelocationtpo2
Scenario: Indigenous Nation Catering Store Relocation Request
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
    And I pay the licensing fee for Catering
    And I request a store relocation for Catering
    And I request a third party operator
    And the account is deleted
    Then I see the login page

 @e2e @catering @partnership @cateringrelocationtpo
 Scenario: Partnership Catering Store Relocation Request
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
    And I pay the licensing fee for Catering
    And I request a store relocation for Catering
    And I request a third party operator
    And the account is deleted
    Then I see the login page

 @e2e @catering @privatecorporation @cateringrelocationtpo
 Scenario: Private Corporation Catering Store Relocation Request
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
    And I pay the licensing fee for Catering
    And I request a store relocation for Catering
    And I request a third party operator
    And the account is deleted
    Then I see the login page

 @e2e @catering @publiccorporation @cateringrelocationtpo2
 Scenario: Public Corporation Catering Store Relocation Request
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
    And I pay the licensing fee for Catering
    And I request a store relocation for Catering
    And I request a third party operator
    And the account is deleted
    Then I see the login page

 @e2e @catering @society @cateringrelocationtpo2
 Scenario: Society Catering Store Relocation Request
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
    And I pay the licensing fee for Catering
    And I request a store relocation for Catering
    And I request a third party operator
    And the account is deleted
    Then I see the login page

 @e2e @catering @soleproprietorship @cateringrelocationtpo
 Scenario: Sole Proprietorship Catering Store Relocation Request
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
    And I pay the licensing fee for Catering
    And I request a store relocation for Catering
    And I request a third party operator
    And the account is deleted
    Then I see the login page