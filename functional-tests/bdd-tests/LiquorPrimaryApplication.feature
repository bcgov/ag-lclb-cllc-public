﻿Feature: LiquorPrimaryApplication
    As a logged in business user
    I want to submit Liquor Primary Applications for different business types

@liquorprimaryapp @release
Scenario: DEV Liquor Primary Application (Private Corporation)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Liquor Primary Licence
    And I review the account profile for a private corporation
    And I complete the Liquor Primary application for a private corporation
    And I click on the Submit button
    And the dashboard status is updated as Pending External Review
    And the account is deleted
    Then I see the login page

@liquorprimaryapp @release
Scenario: DEV Liquor Primary Application (Society)
    Given I am logged in to the dashboard as a society
    And I click on the Start Application button for a Liquor Primary Licence
    And I review the account profile for a society
    And I complete the Liquor Primary application for a society
    And I click on the Submit button
    And the dashboard status is updated as Pending External Review
    And the account is deleted
    Then I see the login page

@liquorprimaryapp @release
Scenario: DEV Liquor Primary Application (Partnership)
    Given I am logged in to the dashboard as a partnership
    And I click on the Start Application button for a Liquor Primary Licence
    And I review the account profile for a partnership
    And I complete the Liquor Primary application for a partnership
    And I click on the Submit button
    And the dashboard status is updated as Pending External Review
    And the account is deleted
    Then I see the login page

@liquorprimaryapp @release
Scenario: DEV Liquor Primary Application (Sole Proprietorship)
    Given I am logged in to the dashboard as a sole proprietorship
    And I click on the Start Application button for a Liquor Primary Licence
    And I review the account profile for a sole proprietorship
    And I complete the Liquor Primary application for a sole proprietorship
    And I click on the Submit button
    And the dashboard status is updated as Pending External Review
    And the account is deleted
    Then I see the login page