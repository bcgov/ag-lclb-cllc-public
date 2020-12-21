﻿Feature: FoodPrimaryCateringEndorsement
    As a logged in business user
    I want to request a Catering Endorsement Application for a Food Primary licence

@foodprimarycateringendorsement @privatecorporation
Scenario: Private Corporation Food Primary Catering Endorsement
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
    # And I pay the licensing fee 
    And I click on the link for Catering Endorsement Application
    And I request a catering endorsement application
    And I click on the Submit button
    And I enter the payment information
    And I click on the link for Dashboard
    And the dashboard status is updated as Application Under Review
    And the account is deleted
    Then I see the login page