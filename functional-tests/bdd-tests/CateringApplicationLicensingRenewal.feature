﻿Feature: CateringApplicationLicensingRenewal
    As a logged in business user
    I want to pay the first year licensing fee for an approved Catering Application
    And renew the licence

@e2e @catering @privatecorporation @licencerenewal
Scenario: Negative Catering Licence Renewal
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for Catering
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Catering application
    And I click on the Submit button
    And I click on the button for Pay for Application
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee for Catering
    And the expiry date is changed to today
    And I renew the licence with negative responses for Catering
    And the account is deleted
    Then I see the login page

@e2e @catering @privatecorporation @licencerenewal
Scenario: Positive Catering Licence Renewal
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for Catering
    And I review the account profile for a private corporation
    And I review the organization structure for a private corporation
    And I click on the button for Submit Organization Information
    And I complete the Catering application
    And I click on the Submit button
    And I click on the button for Pay for Application
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee for Catering
    And the expiry date is changed to today
    And I renew the licence with positive responses for Catering
    And the account is deleted
    Then I see the login page