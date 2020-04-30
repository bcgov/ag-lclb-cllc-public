﻿Feature: CRSApplication_soleproprietor
    As a logged in business user
    I want to submit a CRS Application for a sole proprietorship

Scenario: Start Application
    Given I am logged in to the dashboard as a sole proprietorship
    And the account is deleted
    And I am logged in to the dashboard as a sole proprietorship
    And I click on the Start Application button
    And I complete the eligibility disclosure
    And I review the account profile
    And I review the organization structure
    And I submit the organization structure
    And I complete the application
    And I review the security screening requirements
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the account is deleted
    Then I see the login page