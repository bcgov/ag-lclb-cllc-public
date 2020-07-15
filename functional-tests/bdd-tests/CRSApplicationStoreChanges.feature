﻿Feature: CRSApplicationStoreChanges
    As a logged in business user
    I want to submit a CRS Application for different business types
    And request a store relocation and structural change and transfer of ownership for the approved application

@e2e @cannabis @indigenousnation @crsstorechangesIN
Scenario: Indigenous Nation Cannabis Store Changes
    Given I am logged in to the dashboard as an indigenous nation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile for a indigenous nation
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I pay the licensing fee for Cannabis
    And I request a Cannabis store relocation
    And I request a structural change
    And I request a transfer of ownership
    And the account is deleted
    Then I see the login page

@e2e @cannabis @partnership @crsstorechangespartnership
Scenario: Partnership Cannabis Store Changes
    Given I am logged in to the dashboard as a partnership
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile for a partnership
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I pay the licensing fee for Cannabis
    And I request a Cannabis store relocation
    And I request a structural change
    And I request a transfer of ownership
    And the account is deleted
    Then I see the login page

@e2e @cannabis @privatecorporation @crsstorechangesprivcorp
Scenario: Private Corporation Cannabis Store Changes
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile for a private corporation
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I pay the licensing fee for Cannabis
    And I request a Cannabis store relocation
    And I request a structural change
    And I request a transfer of ownership
    And the account is deleted
    Then I see the login page

@e2e @cannabis @publiccorporation @crsstorechangespubcorp
Scenario: Public Corporation Cannabis Store Changes
    Given I am logged in to the dashboard as a public corporation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile for a public corporation
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I pay the licensing fee for Cannabis
    And I request a Cannabis store relocation
    And I request a structural change
    And I request a transfer of ownership
    And the account is deleted
    Then I see the login page

@e2e @cannabis @society @crsstorechangessociety
Scenario: Society Cannabis Store Changes
    Given I am logged in to the dashboard as a society
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile for a society
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I pay the licensing fee for Cannabis
    And I request a Cannabis store relocation
    And I request a structural change
    And I request a transfer of ownership
    And the account is deleted
    Then I see the login page

@e2e @cannabis @soleproprietorship @crsstorechangessoleprop
Scenario: Sole Proprietorship Cannabis Store Changes
    Given I am logged in to the dashboard as a sole proprietorship
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile for a sole proprietorship
    And I review the organization structure
    And I click on the Submit Organization Information button
    And I complete the Cannabis Retail Store application
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I pay the licensing fee for Cannabis
    And I request a Cannabis store relocation
    And I request a structural change
    And I request a transfer of ownership
    And the account is deleted
    Then I see the login page