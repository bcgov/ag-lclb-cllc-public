﻿Feature: FoodPrimaryBrandingChange
    As a logged in business user
    I want to request an establishment name change application for a Food Primary licence

@foodprimarybranding @privatecorporation
Scenario: Food Primary Establishment Name Change (Private Corporation)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for Food Primary
    And I review the account profile for a private corporation
    And I complete the Food Primary application for a private corporation
    And I click on the Submit button
    And I enter the payment information
    And I confirm the payment receipt for a Food Primary application
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the application is approved
    And I request a valid store name or branding change for Food Primary
    And the account is deleted
    Then I see the login page