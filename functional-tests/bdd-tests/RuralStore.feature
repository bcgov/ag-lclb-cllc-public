﻿Feature: RuralStore.feature
    As a logged in business user
    I want to submit a rural store application for a private corporation

Scenario: Start Application
    Given I am logged in to the dashboard as a private corporation
    And the account is deleted
    And I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Rural Agency Store
    And I review the account profile
    And I review the organization structure
    And I submit the organization structure
    And I complete the Rural Agency Store application
    And I return to the dashboard
    And the account is deleted
    Then I see the login page