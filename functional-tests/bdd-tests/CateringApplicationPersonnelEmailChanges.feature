﻿Feature: CateringApplicationPersonnelEmailChanges
    As a logged in business user
    I want to pay the first year catering licence fee
    And submit personnel email changes for different business types

@catering @partnership @cateringemail
Scenario: Catering Personnel Email Change (Partnership)
    Given I am logged in to the dashboard as a partnership
    And I click on the Start Application button for Catering
    And I review the account profile for a partnership
    And I review the organization structure for a partnership
    And I click on the button for Submit Organization Information
    And I complete the Catering application
    And I click on the Submit button
    And I click on the button for Pay for Application
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee 
    And I click on the link for Dashboard
    And I change a personnel email address for a partnership
    And the account is deleted
    Then I see the login page

@catering @privatecorporation @cateringemail
Scenario: Catering Personnel Email Change (Private Corporation)
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
    And I pay the licensing fee 
    And I click on the link for Dashboard
    And I change a personnel email address for a private corporation
    And the account is deleted
    Then I see the login page

@catering @publiccorporation @cateringemail
Scenario: Catering Personnel Email Change (Public Corporation)
    Given I am logged in to the dashboard as a public corporation
    And I click on the Start Application button for Catering
    And I review the account profile for a public corporation
    And I review the organization structure for a public corporation
    And I click on the button for Submit Organization Information
    And I complete the Catering application
    And I click on the Submit button
    And I click on the button for Pay for Application
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee 
    And I click on the link for Dashboard
    And I change a personnel email address for a public corporation
    And the account is deleted
    Then I see the login page

@catering @society @cateringemail
Scenario: Catering Personnel Email Change (Society)
    Given I am logged in to the dashboard as a society
    And I click on the Start Application button for Catering
    And I review the account profile for a society
    And I review the organization structure for a society
    And I click on the button for Submit Organization Information
    And I complete the Catering application
    And I click on the Submit button
    And I click on the button for Pay for Application
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee 
    And I click on the link for Dashboard
    And I change a personnel email address for a society
    And the account is deleted
    Then I see the login page

@catering @soleproprietorship @cateringemail
Scenario: Catering Personnel Email Change (Sole Proprietorship)
    Given I am logged in to the dashboard as a sole proprietorship
    And I click on the Start Application button for Catering
    And I review the account profile for a sole proprietorship
    And I review the organization structure for a sole proprietorship
    And I click on the button for Submit Organization Information
    And I complete the Catering application
    And I click on the Submit button
    And I click on the button for Pay for Application
    And I enter the payment information
    And the application is approved
    And I pay the licensing fee 
    And I click on the link for Dashboard
    And I change a personnel email address for a sole proprietorship
    And the account is deleted
    Then I see the login page