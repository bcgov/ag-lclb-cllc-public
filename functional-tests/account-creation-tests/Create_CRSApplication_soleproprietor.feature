﻿Feature: Create_CRSApplication_soleproprietor
    As a logged in business user
    I want to submit a CRS Application for a sole proprietorship
    To be used as test data

Scenario: Start Application
    Given I am logged in to the dashboard as a sole proprietorship
    And the account is deleted
    And I am logged in to the dashboard as a sole proprietorship
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile
    And I review the organization structure
    And I submit the organization structure
    And I complete the Cannabis Retail Store application
    And I click on the Pay for Application button
    And I enter the payment information
    And I confirm the payment receipt for a Cannabis Retail Store application
    Then I return to the dashboard   