﻿using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using Protractor;
using System;
using Xunit.Gherkin.Quick;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.IO;
using Xunit;

/*
Feature: MultiLevelCRSApplicationPrivateCorp
    As a logged in business user
    I want to submit a CRS Application for a private corporation
    With multiple nested business shareholders

Scenario: Start Application
    Given I am logged in to the dashboard as a private corporation
    And the account is deleted
    And I am logged in to the dashboard as a private corporation
    And I click on the Start Application button
    And I complete the eligibility disclosure
    And I review the account profile
    And I review the organization structure
    And I add in multiple nested business shareholders
    And I submit the organization information
    And I complete the application
    And I review the security screening requirements
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the account is deleted
    Then I see the login page
*/

namespace bdd_tests
{
    [FeatureFile("./MultiLevelCRSApplicationPrivateCorp.feature")]
    public sealed class MultiLevelCRSApplicationPrivateCorp : TestBase
    {
        public void CheckFeatureFlagsCannabis()
        {
            string feature_flags = configuration["featureFlags"];

            // navigate to the feature flags page
            driver.Navigate().GoToUrl($"{baseUri}{feature_flags}");

            // confirm that the CRS-Renewal flag is enabled during this test
            Assert.True(driver.FindElement(By.XPath("//body[contains(.,'CRS-Renewal')]")).Displayed);
        }

        [Given(@"I am logged in to the dashboard as a (.*)")]
        public void I_view_the_dashboard(string businessType)
        {
            CheckFeatureFlagsCannabis();
            
            CarlaLoginNoCheck();
        }

        [And(@"I am logged in to the dashboard as a (.*)")]
        public void And_I_view_the_dashboard(string businessType)
        {
            CarlaLogin(businessType);
        }

        [And(@"I click on the Start Application button")]
        public void I_start_application()
        {
            /* 
            Page Title: Welcome to Cannabis Licensing
            */

            // click on the Start Application button
            NgWebElement startApp_button = ngDriver.FindElement(By.XPath("//button[text()='START APPLICATION']"));
            startApp_button.Click();
        }

        [And(@"I complete the eligibility disclosure")]
        public void complete_eligibility_disclosure()
        {
            CRSEligibilityDisclosure();
        }

        [And(@"I review the account profile")]
        public void review_account_profile()
        {
            ReviewAccountProfile();
        }

        [And(@"I review the organization structure")]
        public void I_continue_to_organization_review()
        {
            /* 
            Page Title: [client name] Detailed Organization Information
            */

            // find the upload test files in the bdd-tests\upload_files folder
            var environment = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(environment).Parent.FullName;
            string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;

            // upload a notice of articles document
            string noticeOfArticles = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "signage.pdf");
            NgWebElement uploadSignage = ngDriver.FindElement(By.XPath("(//input[@type='file'])[3]"));
            uploadSignage.SendKeys(noticeOfArticles);

            // upload a central securities register document
            string centralSecuritiesRegister = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "signage.pdf");
            NgWebElement uploadCentralSecReg = ngDriver.FindElement(By.XPath("(//input[@type='file'])[6]"));
            uploadCentralSecReg.SendKeys(centralSecuritiesRegister);

            // upload a special rights and restrictions document
            string specialRightsRestrictions = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "signage.pdf");
            NgWebElement uploadSpecialRightsRes = ngDriver.FindElement(By.XPath("(//input[@type='file'])[9]"));
            uploadSpecialRightsRes.SendKeys(specialRightsRestrictions);

            /********** Key Personnel **********/

            // create the key personnel data
            string keyPersonnelFirstName = "Jane";
            string keyPersonnelLastName = "Bond";
            string keyPersonnelTitle = "Adventurer";
            string keyPersonnelEmail = "jane@bond.com";

            // open key personnel form   
            NgWebElement openKeyPersonnelForm = ngDriver.FindElement(By.XPath("//div[@id='cdk-step-content-0-1']/app-application-licensee-changes/div/section[1]/app-org-structure/div[4]/section/app-associate-list/div/button"));
            openKeyPersonnelForm.Click();

            // enter key personnel first name
            NgWebElement uiKeyPersonFirst = ngDriver.FindElement(By.XPath("//input[@type='text']"));
            uiKeyPersonFirst.SendKeys(keyPersonnelFirstName);

            // enter key personnel last name
            NgWebElement uiKeyPersonLast = ngDriver.FindElement(By.XPath("(//input[@type='text'])[2]"));
            uiKeyPersonLast.SendKeys(keyPersonnelLastName);

            // select key personnel role
            NgWebElement uiKeyPersonRole = ngDriver.FindElement(By.XPath("//input[@type='checkbox']"));
            uiKeyPersonRole.Click();

            // enter key personnel title
            NgWebElement uiKeyPersonTitle = ngDriver.FindElement(By.XPath("(//input[@type='text'])[3]"));
            uiKeyPersonTitle.SendKeys(keyPersonnelTitle);

            // enter key personnel email
            NgWebElement uiKeyPersonEmail = ngDriver.FindElement(By.XPath("(//input[@type='text'])[4]"));
            uiKeyPersonEmail.SendKeys(keyPersonnelEmail);

            // enter key personnel DOB
            NgWebElement openKeyPersonnelDOB = ngDriver.FindElement(By.XPath("(//input[@type='text'])[5]"));
            openKeyPersonnelDOB.Click();

            NgWebElement openKeyPersonnelDOB1 = ngDriver.FindElement(By.XPath("//*[@id='mat-datepicker-3']/div/mat-month-view/table/tbody/tr[2]/td[1]/div"));
            openKeyPersonnelDOB1.Click();

            /********** Individual Shareholder **********/

            // create the shareholder data
            string shareholderFirstName = "Jacqui";
            string shareholderLastName = "Chan";
            string shareholderVotingShares = "500";
            string shareholderEmail = "jacqui@chan.com";

            // open shareholder form    
            NgWebElement uiOpenShare = ngDriver.FindElement(By.XPath("//div[@id='cdk-step-content-0-1']/app-application-licensee-changes/div/section/app-org-structure/div[5]/section/app-associate-list/div/button"));
            uiOpenShare.Click();

            // enter shareholder first name
            NgWebElement uiShareFirst = ngDriver.FindElement(By.XPath("(//input[@type='text'])[6]"));
            uiShareFirst.SendKeys(shareholderFirstName);

            // enter shareholder last name
            NgWebElement uiShareLast = ngDriver.FindElement(By.XPath("(//input[@type='text'])[7]"));
            uiShareLast.SendKeys(shareholderLastName);

            // enter number of voting shares
            NgWebElement uiShareVotes = ngDriver.FindElement(By.XPath("(//input[@type='text'])[8]"));
            uiShareVotes.SendKeys(shareholderVotingShares);

            // enter shareholder email
            NgWebElement uiShareEmail = ngDriver.FindElement(By.XPath("(//input[@type='text'])[9]"));
            uiShareEmail.SendKeys(shareholderEmail);

            // enter shareholder DOB
            NgWebElement uiCalendarS1 = ngDriver.FindElement(By.XPath("(//input[@type='text'])[10]"));
            uiCalendarS1.Click();

            NgWebElement uiCalendarS2 = ngDriver.FindElement(By.XPath("//*[@id='mat-datepicker-4']/div/mat-month-view/table/tbody/tr[2]/td[1]/div"));
            uiCalendarS2.Click();

            /********** Business Shareholder **********/

            // create the business shareholder data
            string businessName = "Bourne Enterprises";
            string businessVotingShares = "50";
            string businessEmail = "bourne@enterprises.com";

            // open business shareholder form    
            NgWebElement uiOpenShareBiz = ngDriver.FindElement(By.XPath("//div[@id='cdk-step-content-0-1']/app-application-licensee-changes/div/section/app-org-structure/div[5]/section[2]/app-associate-list/div/button"));
            uiOpenShareBiz.Click();

            // enter business name
            NgWebElement uiShareFirstBiz = ngDriver.FindElement(By.XPath("(//input[@type='text'])[11]"));
            uiShareFirstBiz.SendKeys(businessName);

            // enter business voting shares
            NgWebElement uiShareVotesBiz = ngDriver.FindElement(By.XPath("(//input[@type='text'])[12]"));
            uiShareVotesBiz.SendKeys(businessVotingShares);

            // select the business type
            NgWebElement uiShareBizType = ngDriver.FindElement(By.XPath("//*[@id='cdk-step-content-0-1']/app-application-licensee-changes/div/section[1]/app-org-structure/div[5]/section[2]/app-associate-list/div/table/tr/td[3]/app-field/section/div[1]/section/select/option[2]"));
            uiShareBizType.Click();

            // enter business shareholder email
            NgWebElement uiShareEmailBiz = ngDriver.FindElement(By.XPath("(//input[@type='text'])[13]"));
            uiShareEmailBiz.SendKeys(businessEmail);

            // select the business shareholder confirm button
            NgWebElement uiShareBizConfirmButton = ngDriver.FindElement(By.XPath("//div[@id='cdk-step-content-0-1']/app-application-licensee-changes/div/section/app-org-structure/div[5]/section[2]/app-associate-list/div/table/tr/td[5]/i/span"));
            uiShareBizConfirmButton.Click();

            // upload a notice of articles document for business shareholder
            string noticeOfArticlesBiz = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "notice_of_articles.pdf");
            NgWebElement uploadNoticeofArticlesBiz = ngDriver.FindElement(By.XPath("(//input[@type='file'])[12]"));
            uploadNoticeofArticlesBiz.SendKeys(noticeOfArticlesBiz);

            // upload a central securities register document for business shareholder
            string centralSecuritiesRegisterBiz = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "central_securities_register.pdf");
            NgWebElement uploadCentralSecRegBiz = ngDriver.FindElement(By.XPath("(//input[@type='file'])[15]"));
            uploadCentralSecRegBiz.SendKeys(centralSecuritiesRegisterBiz);

            // upload a special rights and restrictions document for business shareholder
            string specialRightsRestrictionsBiz = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "special_rights_restrictions.pdf");
            NgWebElement uploadSpecialRightsResBiz = ngDriver.FindElement(By.XPath("(//input[@type='file'])[18]"));
            uploadSpecialRightsResBiz.SendKeys(specialRightsRestrictionsBiz);

            /********** Business Shareholder - Key Personnel **********/

            // create business shareholder key personnel data
            string keyPersonnelFirstNameBiz = "Ethel";
            string keyPersonnelLastNameBiz = "Hunt";
            string keyPersonnelTitleBiz = "Climbing Enthusiast";
            string keyPersonnelEmailBiz = "ethel@hunt.com";

            // open business shareholder > key personnel form
            NgWebElement openKeyPersonnelFormBiz = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-0']/div/section/app-org-structure/div[4]/section/app-associate-list/div/button"));
            openKeyPersonnelFormBiz.Click();

            // enter business shareholder > key personnel first name
            NgWebElement uiKeyPersonFirstBiz = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-0']/div/section/app-org-structure/div[4]/section/app-associate-list/div/table/tr/td[1]/app-field/section/div[1]/section/input"));
            uiKeyPersonFirstBiz.SendKeys(keyPersonnelFirstNameBiz);

            // enter business shareholder > key personnel last name
            NgWebElement uiKeyPersonLastBiz = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-0']/div/section/app-org-structure/div[4]/section/app-associate-list/div/table/tr/td[2]/app-field/section/div[1]/section/input"));
            uiKeyPersonLastBiz.SendKeys(keyPersonnelLastNameBiz);

            // select business shareholder > key personnel role
            NgWebElement uiKeyPersonRoleBiz = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-0']/div/section/app-org-structure/div[4]/section/app-associate-list/div/table/tr/td[3]/app-field/section/div/section/table/tr/td[1]/input[1]"));
            uiKeyPersonRoleBiz.Click();

            // enter business shareholder > key personnel title
            NgWebElement uiKeyPersonTitleBiz = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-0']/div/section/app-org-structure/div[4]/section/app-associate-list/div/table/tr/td[4]/app-field/section/div/section/input"));
            uiKeyPersonTitleBiz.SendKeys(keyPersonnelTitleBiz);

            // enter business shareholder > key personnel email
            NgWebElement uiKeyPersonEmailBiz = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-0']/div/section/app-org-structure/div[4]/section/app-associate-list/div/table/tr/td[5]/app-field/section/div[1]/section/input"));
            uiKeyPersonEmailBiz.SendKeys(keyPersonnelEmailBiz);

            // enter business shareholder > key personnel DOB
            NgWebElement uiKeyPersonnelDOB1Biz1 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-0']/div/section/app-org-structure/div[4]/section/app-associate-list/div/table/tr/td[6]/app-field/section/div[1]/section/input"));
            uiKeyPersonnelDOB1Biz1.Click();

            NgWebElement uiKeyPersonnelDOB1Biz2 = ngDriver.FindElement(By.XPath("//*[@id='mat-datepicker-5']/div/mat-month-view/table/tbody/tr[2]/td[1]/div"));
            uiKeyPersonnelDOB1Biz2.Click();

            /********** Business Shareholder - Individual Shareholder **********/

            // create the business shareholder > individual shareholder data
            string shareholderFirstNameBiz = "Jacintha";
            string shareholderLastNameBiz = "Ryan";
            string shareholderVotingSharesBiz = "500";
            string shareholderEmailBiz = "jacintha@cia.com";

            // open business shareholder > individual shareholder form
            NgWebElement uiOpenIndyShareBiz = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-0']/div/section/app-org-structure/div[5]/section[1]/app-associate-list/div/button"));
            uiOpenIndyShareBiz.Click();

            // enter business shareholder > individual shareholder first name
            NgWebElement uiIndyShareFirstBiz = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-0']/div/section/app-org-structure/div[5]/section[1]/app-associate-list/div/table/tr/td[1]/app-field/section/div[1]/section/input"));
            uiIndyShareFirstBiz.SendKeys(shareholderFirstNameBiz);

            // enter business shareholder > individual shareholder last name
            NgWebElement uiIndyShareLastBiz = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-0']/div/section/app-org-structure/div[5]/section[1]/app-associate-list/div/table/tr/td[2]/app-field/section/div[1]/section/input"));
            uiIndyShareLastBiz.SendKeys(shareholderLastNameBiz);

            // enter business shareholder > individual number of voting shares
            NgWebElement uiIndyShareVotesBiz = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-0']/div/section/app-org-structure/div[5]/section[1]/app-associate-list/div/table/tr/td[3]/app-field/section/div[1]/section/div/input"));
            uiIndyShareVotesBiz.SendKeys(shareholderVotingSharesBiz);

            // enter business shareholder > individual shareholder email
            NgWebElement uiIndyShareEmailBiz = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-0']/div/section/app-org-structure/div[5]/section[1]/app-associate-list/div/table/tr/td[4]/app-field/section/div[1]/section/input"));
            uiIndyShareEmailBiz.SendKeys(shareholderEmailBiz);

            // enter business shareholder > individual shareholder DOB
            NgWebElement uiCalendarIndyS1Biz = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-0']/div/section/app-org-structure/div[5]/section[1]/app-associate-list/div/table/tr/td[5]/app-field/section/div[1]/section/input"));
            uiCalendarIndyS1Biz.Click();

            NgWebElement uiCalendarIndyS2Biz = ngDriver.FindElement(By.XPath("//*[@id='mat-datepicker-6']/div/mat-month-view/table/tbody/tr[4]/td[4]/div"));
            uiCalendarIndyS2Biz.Click();
        }

        [And(@"I add in multiple nested business shareholders")]
        public void add_multiple_business_shareholders()
        {
            // add in an additional four nested business shareholders
            business_shareholder_2();
            business_shareholder_3();
            business_shareholder_4();
            business_shareholder_5();
        }

        [And(@"I submit the organization information")]
        public void submit_org_info()
        {
            // click on Submit Organization Info button
            NgWebElement submitOrgInfoButton = ngDriver.FindElement(By.XPath("//button[contains(.,' SUBMIT ORGANIZATION INFORMATION')]"));
            submitOrgInfoButton.Click();
        }

        [And(@"I complete the application")]
        public void I_complete_the_application()
        {
            /* 
            Page Title: Submit the Cannabis Retail Store Application
            */

            // create application info
            string estName = "Point Ellis Greenhouse";
            string estAddress = "645 Tyee Rd";
            string estCity = "Victoria";
            string estPostal = "V9A6X5";
            string estPID = "012345678";
            string estEmail = "test@test.com";
            string estPhone = "2505555555";
            string conGiven = "Given";
            string conSurname = "Surname";
            string conRole = "CEO";
            string conPhone = "2508888888";
            string conEmail = "contact@email.com";

            System.Threading.Thread.Sleep(11000);

            // enter the establishment name
            NgWebElement estabName = ngDriver.FindElement(By.Id("establishmentName"));
            estabName.SendKeys(estName);

            // enter the establishment address
            NgWebElement estabAddress = ngDriver.FindElement(By.Id("establishmentAddressStreet"));
            estabAddress.SendKeys(estAddress);

            // enter the establishment city
            NgWebElement estabCity = ngDriver.FindElement(By.Id("establishmentAddressCity"));
            estabCity.SendKeys(estCity);

            // enter the establishment postal code
            NgWebElement estabPostal = ngDriver.FindElement(By.Id("establishmentAddressPostalCode"));
            estabPostal.SendKeys(estPostal);

            // enter the PID
            NgWebElement estabPID = ngDriver.FindElement(By.Id("establishmentParcelId"));
            estabPID.SendKeys(estPID);

            // enter the store email
            NgWebElement estabEmail = ngDriver.FindElement(By.Id("establishmentEmail"));
            estabEmail.SendKeys(estEmail);

            // enter the store phone number
            NgWebElement estabPhone = ngDriver.FindElement(By.Id("establishmentPhone"));
            estabPhone.SendKeys(estPhone);

            // find the upload test files in the bdd-tests\upload_files folder
            var environment = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(environment).Parent.FullName;
            string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;

            // upload a store signage document
            string signagePath = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "signage.pdf");
            NgWebElement uploadSignage = ngDriver.FindElement(By.XPath("(//input[@type='file'])[2]"));
            uploadSignage.SendKeys(signagePath);

            // upload a valid interest document
            string validInterestPath = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "valid_interest.pdf");
            NgWebElement uploadValidInterest = ngDriver.FindElement(By.XPath("(//input[@type='file'])[6]"));
            uploadValidInterest.SendKeys(validInterestPath);

            // upload a floor plan document
            string floorplanPath = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "floor_plan.pdf");
            NgWebElement uploadFloorplan = ngDriver.FindElement(By.XPath("(//input[@type='file'])[8]"));
            uploadFloorplan.SendKeys(floorplanPath);

            // upload a site plan document
            string sitePlanPath = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "site_plan.pdf");
            NgWebElement uploadSitePlan = ngDriver.FindElement(By.XPath("(//input[@type='file'])[11]"));
            uploadSitePlan.SendKeys(sitePlanPath);

            // upload a financial integrity form
            string finIntegrityPath = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "fin_integrity.pdf");
            NgWebElement uploadFinIntegrity = ngDriver.FindElement(By.XPath("(//input[@type='file'])[15]"));
            uploadFinIntegrity.SendKeys(finIntegrityPath);

            // enter the first name of the application contact
            NgWebElement contactGiven = ngDriver.FindElement(By.Id("contactPersonFirstName"));
            contactGiven.SendKeys(conGiven);

            // enter the last name of the application contact
            NgWebElement contactSurname = ngDriver.FindElement(By.Id("contactPersonLastName"));
            contactSurname.SendKeys(conSurname);

            // enter the role of the application contact
            NgWebElement contactRole = ngDriver.FindElement(By.CssSelector("input[formControlName=contactPersonRole]"));
            contactRole.SendKeys(conRole);

            // enter the phone number of the application contact
            NgWebElement contactPhone = ngDriver.FindElement(By.CssSelector("input[formControlName=contactPersonPhone]"));
            contactPhone.SendKeys(conPhone);

            // enter the email of the application contact
            NgWebElement contactEmail = ngDriver.FindElement(By.Id("contactPersonEmail"));
            contactEmail.SendKeys(conEmail);

            // click on the authorized to submit checkbox
            NgWebElement authorizedSubmit = ngDriver.FindElement(By.Id("authorizedToSubmit"));
            authorizedSubmit.Click();

            // click on the signature agreement checkbox
            NgWebElement signatureAgree = ngDriver.FindElement(By.Id("signatureAgreement"));
            signatureAgree.Click();

            // click on the Submit button
            NgWebElement submit_button = ngDriver.FindElement(By.XPath("//button[contains(.,'SUBMIT')]"));
            submit_button.Click();
        }

        [And(@"I review the security screening requirements")]
        public void review_security_screening_reqs()
        {
            /* 
            Page Title: Security Screening Requirements
                      : placeholder for future testing
            */
        }

        [And(@"I click on the Pay for Application button")]
        public void click_on_pay()
        {
            NgWebElement pay_button = ngDriver.FindElement(By.XPath("//button[contains(.,'Pay for Application')]"));
            pay_button.Click();
        }

        [And(@"I enter the payment information")]
        public void enter_payment_info()
        {
            MakePayment();
        }

        [And(@"I return to the dashboard")]
        public void return_to_dashboard()
        {
            /* 
            Page Title: Payment Approved
            */

            CRSReturnToDashboard();
        }

        [And(@"the account is deleted")]
        public void Delete_my_account()
        {
            this.CarlaDeleteCurrentAccount();
        }

        [Then(@"I see the login page")]
        public void I_see_login()
        {
            /* 
            Page Title: Apply for a cannabis licence
            */

            Assert.True(ngDriver.FindElement(By.XPath("//a[text()='Log In']")).Displayed);
        }

        public void business_shareholder_2()
        {
            /********** Business Shareholder #2 **********/

            // create the business shareholder data
            string businessName2 = "Business Shareholder 2";
            string businessVotingShares2 = "100";
            string businessEmail2 = "businessshareholder2@email.com";

            // open business shareholder form - GardaWorld
            NgWebElement uiOpenShareBiz2 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-0']/div/section/app-org-structure/div[5]/section[2]/app-associate-list/div/button"));
            uiOpenShareBiz2.Click();

            // enter business name
            NgWebElement uiShareFirstBiz2 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-0']/div/section/app-org-structure/div[5]/section[2]/app-associate-list/div/table/tr/td[1]/app-field/section/div[1]/section/input"));
            uiShareFirstBiz2.SendKeys(businessName2);

            // enter business voting shares
            NgWebElement uiShareVotesBiz2 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-0']/div/section/app-org-structure/div[5]/section[2]/app-associate-list/div/table/tr/td[2]/app-field/section/div/section/input"));
            uiShareVotesBiz2.SendKeys(businessVotingShares2);

            // select the business type from dropdown
            NgWebElement uiShareBizType2 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-0']/div/section/app-org-structure/div[5]/section[2]/app-associate-list/div/table/tr/td[3]/app-field/section/div/section/select/option[2]"));
            uiShareBizType2.Click();

            // enter business shareholder email
            NgWebElement uiShareEmailBiz2 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-0']/div/section/app-org-structure/div[5]/section[2]/app-associate-list/div/table/tr/td[4]/app-field/section/div[1]/section/input"));
            uiShareEmailBiz2.SendKeys(businessEmail2);

            // select the business shareholder confirm button
            NgWebElement uiShareBizConfirmButton2 = ngDriver.FindElement(By.XPath("//div[@id='cdk-accordion-child-0']/div/section/app-org-structure/div[5]/section[2]/app-associate-list/div/table/tr/td[5]/i/span"));
            uiShareBizConfirmButton2.Click();
            
            // find the upload test files in the bdd-tests\upload_files folder
            var environment = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(environment).Parent.FullName;
            string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;

            // upload a notice of articles document for business shareholder
            string noticeOfArticlesBiz2 = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "notice_of_articles.pdf");
            NgWebElement uploadNoticeofArticlesBiz2 = ngDriver.FindElement(By.XPath("(//input[@type='file'])[21]"));
            uploadNoticeofArticlesBiz2.SendKeys(noticeOfArticlesBiz2);

            // upload a central securities register document for business shareholder
            string centralSecuritiesRegisterBiz2 = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "central_securities_register.pdf");
            NgWebElement uploadCentralSecRegBiz2 = ngDriver.FindElement(By.XPath("(//input[@type='file'])[24]"));
            uploadCentralSecRegBiz2.SendKeys(centralSecuritiesRegisterBiz2);

            // upload a special rights and restrictions document for business shareholder
            string specialRightsRestrictionsBiz2 = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "special_rights_restrictions.pdf");
            NgWebElement uploadSpecialRightsResBiz2 = ngDriver.FindElement(By.XPath("(//input[@type='file'])[27]"));
            uploadSpecialRightsResBiz2.SendKeys(specialRightsRestrictionsBiz2);

            /********** Business Shareholder #2 - Key Personnel **********/

            // create business shareholder key personnel data
            string keyPersonnelFirstNameBiz2 = "KeyPersonnelBiz2First";
            string keyPersonnelLastNameBiz2 = "KeyPersonnelBiz2Last";
            string keyPersonnelTitleBiz2 = "KeyPersonnelBiz2Title";
            string keyPersonnelEmailBiz2 = "keypersonnel@biz2.com";

            // open business shareholder > key personnel form 
            NgWebElement openKeyPersonnelFormBiz2 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-1']/div/section/app-org-structure/div[4]/section/app-associate-list/div/button"));
            openKeyPersonnelFormBiz2.Click();

            // enter business shareholder > key personnel first name
            NgWebElement uiKeyPersonFirstBiz2 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-1']/div/section/app-org-structure/div[4]/section/app-associate-list/div/table/tr/td[1]/app-field/section/div[1]/section/input"));
            uiKeyPersonFirstBiz2.SendKeys(keyPersonnelFirstNameBiz2);

            // enter business shareholder > key personnel last name
            NgWebElement uiKeyPersonLastBiz2 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-1']/div/section/app-org-structure/div[4]/section/app-associate-list/div/table/tr/td[2]/app-field/section/div[1]/section/input"));
            uiKeyPersonLastBiz2.SendKeys(keyPersonnelLastNameBiz2);

            // select business shareholder > key personnel role using checkbox
            NgWebElement uiKeyPersonRoleBiz2 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-1']/div/section/app-org-structure/div[4]/section/app-associate-list/div/table/tr/td[3]/app-field/section/div/section/table/tr/td[1]/input[1]"));
            uiKeyPersonRoleBiz2.Click();

            // enter business shareholder > key personnel title
            NgWebElement uiKeyPersonTitleBiz2 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-1']/div/section/app-org-structure/div[4]/section/app-associate-list/div/table/tr/td[4]/app-field/section/div/section/input"));
            uiKeyPersonTitleBiz2.SendKeys(keyPersonnelTitleBiz2);

            // enter business shareholder > key personnel email
            NgWebElement uiKeyPersonEmailBiz2 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-1']/div/section/app-org-structure/div[4]/section/app-associate-list/div/table/tr/td[5]/app-field/section/div[1]/section/input"));
            uiKeyPersonEmailBiz2.SendKeys(keyPersonnelEmailBiz2);

            // enter business shareholder > key personnel DOB
            NgWebElement uiKeyPersonnelDOB1Biz12 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-1']/div/section/app-org-structure/div[4]/section/app-associate-list/div/table/tr/td[6]/app-field/section/div[1]/section/input"));
            uiKeyPersonnelDOB1Biz12.Click();

            NgWebElement uiKeyPersonnelDOB1Biz22 = ngDriver.FindElement(By.XPath("//*[@id='mat-datepicker-7']/div/mat-month-view/table/tbody/tr[2]/td[1]/div"));
            uiKeyPersonnelDOB1Biz22.Click();

            /********** Business Shareholder #2 - Individual Shareholder **********/

            // create the business shareholder > individual shareholder data
            string shareholderFirstNameBiz2 = "IndividualShareholderBiz2First";
            string shareholderLastNameBiz2 = "IndividualShareholderBiz2Last";
            string shareholderVotingSharesBiz2 = "1800";
            string shareholderEmailBiz2 = "individualshareholder@biz2.com";

            // open business shareholder > individual shareholder form
            NgWebElement uiOpenIndyShareBiz2 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-1']/div/section/app-org-structure/div[5]/section[1]/app-associate-list/div/button"));
            uiOpenIndyShareBiz2.Click();

            // enter business shareholder > individual shareholder first name
            NgWebElement uiIndyShareFirstBiz2 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-1']/div/section/app-org-structure/div[5]/section[1]/app-associate-list/div/table/tr/td[1]/app-field/section/div[1]/section/input"));
            uiIndyShareFirstBiz2.SendKeys(shareholderFirstNameBiz2);

            // enter business shareholder > individual shareholder last name
            NgWebElement uiIndyShareLastBiz2 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-1']/div/section/app-org-structure/div[5]/section[1]/app-associate-list/div/table/tr/td[2]/app-field/section/div[1]/section/input"));
            uiIndyShareLastBiz2.SendKeys(shareholderLastNameBiz2);

            // enter business shareholder > individual number of voting shares
            NgWebElement uiIndyShareVotesBiz2 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-1']/div/section/app-org-structure/div[5]/section[1]/app-associate-list/div/table/tr/td[3]/app-field/section/div[1]/section/div/input"));
            uiIndyShareVotesBiz2.SendKeys(shareholderVotingSharesBiz2);

            // enter business shareholder > individual shareholder email
            NgWebElement uiIndyShareEmailBiz2 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-1']/div/section/app-org-structure/div[5]/section[1]/app-associate-list/div/table/tr/td[4]/app-field/section/div[1]/section/input"));
            uiIndyShareEmailBiz2.SendKeys(shareholderEmailBiz2);

            // enter business shareholder > individual shareholder DOB
            NgWebElement uiCalendarIndyS1Biz2 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-1']/div/section/app-org-structure/div[5]/section[1]/app-associate-list/div/table/tr/td[5]/app-field/section/div[1]/section/input"));
            uiCalendarIndyS1Biz2.Click();

            NgWebElement uiCalendarIndyS2Biz2 = ngDriver.FindElement(By.XPath("//*[@id='mat-datepicker-8']/div/mat-month-view/table/tbody/tr[2]/td[1]/div"));
            uiCalendarIndyS2Biz2.Click();
        }
        public void business_shareholder_3()
        {
            /********** Business Shareholder #3 **********/

            // create the business shareholder data
            string businessName3 = "Business Shareholder 3";
            string businessVotingShares3 = "3";
            string businessEmail3 = "businessshareholder3@email.com";

            // open business shareholder form
            NgWebElement uiOpenShareBiz3 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-1']/div/section/app-org-structure/div[4]/section[2]/app-associate-list/div/button"));
            uiOpenShareBiz3.Click();

            // enter business name
            NgWebElement uiShareFirstBiz3 = ngDriver.FindElement(By.XPath("(//input[@type='text'])[31]"));
            uiShareFirstBiz3.SendKeys(businessName3);

            // enter business voting shares
            NgWebElement uiShareVotesBiz3 = ngDriver.FindElement(By.XPath("(//input[@type='text'])[32]"));
            uiShareVotesBiz3.SendKeys(businessVotingShares3);

            // select the business type using dropdown
            NgWebElement uiShareBizType3 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-1']/div/section/app-org-structure/div[4]/section[2]/app-associate-list/div/table/tr/td[3]/app-field/section/div/section/select/option[2]"));
            uiShareBizType3.Click();

            // enter business shareholder email
            NgWebElement uiShareEmailBiz3 = ngDriver.FindElement(By.XPath("(//input[@type='text'])[33]"));
            uiShareEmailBiz3.SendKeys(businessEmail3);

            // select the business shareholder confirm button
            NgWebElement uiShareBizConfirmButton3 = ngDriver.FindElement(By.XPath("//div[@id='cdk-accordion-child-1']/div/section/app-org-structure/div[4]/section[2]/app-associate-list/div/table/tr/td[5]/i/span"));
            uiShareBizConfirmButton3.Click();

            // find the upload test files in the bdd-tests\upload_files folder
            var environment = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(environment).Parent.FullName;
            string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;

            // upload a notice of articles document for business shareholder
            string noticeOfArticlesBiz3 = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "notice_of_articles.pdf");
            NgWebElement uploadNoticeofArticlesBiz3 = ngDriver.FindElement(By.XPath("(//input[@type='file'])[30]"));
            uploadNoticeofArticlesBiz3.SendKeys(noticeOfArticlesBiz3);

            // upload a central securities register document for business shareholder
            string centralSecuritiesRegisterBiz3 = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "central_securities_register.pdf");
            NgWebElement uploadCentralSecRegBiz3 = ngDriver.FindElement(By.XPath("(//input[@type='file'])[33]"));
            uploadCentralSecRegBiz3.SendKeys(centralSecuritiesRegisterBiz3);

            // upload a special rights and restrictions document for business shareholder
            string specialRightsRestrictionsBiz3 = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "special_rights_restrictions.pdf");
            NgWebElement uploadSpecialRightsResBiz3 = ngDriver.FindElement(By.XPath("(//input[@type='file'])[36]"));
            uploadSpecialRightsResBiz3.SendKeys(specialRightsRestrictionsBiz3);

            /********** Business Shareholder #3 - Key Personnel **********/

            // create business shareholder key personnel data
            string keyPersonnelFirstNameBiz3 = "KeyPersonnelBiz3First";
            string keyPersonnelLastNameBiz3 = "KeyPersonnelBiz3Last";
            string keyPersonnelTitleBiz3 = "KeyPersonnelBiz3Title";
            string keyPersonnelEmailBiz3 = "keypersonnel@biz3.com";

            // open business shareholder > key personnel form
            NgWebElement openKeyPersonnelFormBiz3 = ngDriver.FindElement(By.XPath("//div[@id='cdk-accordion-child-2']/div/section/app-org-structure/div[3]/section/app-associate-list/div/button"));
            openKeyPersonnelFormBiz3.Click();

            // enter business shareholder > key personnel first name
            NgWebElement uiKeyPersonFirstBiz3 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-2']/div/section/app-org-structure/div[3]/section/app-associate-list/div/table/tr/td[1]/app-field/section/div[1]/section/input"));
            uiKeyPersonFirstBiz3.SendKeys(keyPersonnelFirstNameBiz3);

            // enter business shareholder > key personnel last name
            NgWebElement uiKeyPersonLastBiz3 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-2']/div/section/app-org-structure/div[3]/section/app-associate-list/div/table/tr/td[2]/app-field/section/div[1]/section/input"));
            uiKeyPersonLastBiz3.SendKeys(keyPersonnelLastNameBiz3);

            // select business shareholder > key personnel role using checkbox
            NgWebElement uiKeyPersonRoleBiz3 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-2']/div/section/app-org-structure/div[3]/section/app-associate-list/div/table/tr/td[3]/app-field/section/div/section/table/tr/td[1]/input[1]"));
            uiKeyPersonRoleBiz3.Click();

            // enter business shareholder > key personnel title
            NgWebElement uiKeyPersonTitleBiz3 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-2']/div/section/app-org-structure/div[3]/section/app-associate-list/div/table/tr/td[4]/app-field/section/div/section/input"));
            uiKeyPersonTitleBiz3.SendKeys(keyPersonnelTitleBiz3);

            // enter business shareholder > key personnel email
            NgWebElement uiKeyPersonEmailBiz3 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-2']/div/section/app-org-structure/div[3]/section/app-associate-list/div/table/tr/td[5]/app-field/section/div[1]/section/input"));
            uiKeyPersonEmailBiz3.SendKeys(keyPersonnelEmailBiz3);

            // enter business shareholder > key personnel DOB
            NgWebElement uiKeyPersonnelDOB1Biz13 = ngDriver.FindElement(By.XPath("/html/body/app-root/div/div/div/main/div/app-multi-stage-application-flow/div/mat-horizontal-stepper/div[2]/div[2]/app-application-licensee-changes/div/section[1]/app-org-structure/div[5]/section[2]/app-associate-list/div/table/tr[2]/td/mat-expansion-panel/div/div/section/app-org-structure/div[4]/section[2]/app-associate-list/div/table/tr[2]/td/mat-expansion-panel/div/div/section/app-org-structure/div[4]/section[2]/app-associate-list/div/table/tr[2]/td/mat-expansion-panel/div/div/section/app-org-structure/div[3]/section/app-associate-list/div/table/tr/td[6]/app-field/section/div[1]/section/input"));
            uiKeyPersonnelDOB1Biz13.Click();

            NgWebElement uiKeyPersonnelDOB1Biz23 = ngDriver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/mat-datepicker-content/mat-calendar/div/mat-month-view/table/tbody/tr[2]/td[1]/div"));
            uiKeyPersonnelDOB1Biz23.Click();

            /********** Business Shareholder #3 - Individual Shareholder **********/

            // create the business shareholder > individual shareholder data
            string shareholderFirstNameBiz3 = "IndividualShareholderBiz3First";
            string shareholderLastNameBiz3 = "IndividualShareholderBiz3Last";
            string shareholderVotingSharesBiz3 = "1000";
            string shareholderEmailBiz3 = "individualshareholder@biz3.com";

            // open business shareholder > individual shareholder form
            NgWebElement uiOpenIndyShareBiz3 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-2']/div/section/app-org-structure/div[4]/section[1]/app-associate-list/div/button"));
            uiOpenIndyShareBiz3.Click();

            // enter business shareholder > individual shareholder first name
            NgWebElement uiIndyShareFirstBiz3 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-2']/div/section/app-org-structure/div[4]/section[1]/app-associate-list/div/table/tr/td[1]/app-field/section/div[1]/section/input"));
            uiIndyShareFirstBiz3.SendKeys(shareholderFirstNameBiz3);

            // enter business shareholder > individual shareholder last name
            NgWebElement uiIndyShareLastBiz3 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-2']/div/section/app-org-structure/div[4]/section[1]/app-associate-list/div/table/tr/td[2]/app-field/section/div[1]/section/input"));
            uiIndyShareLastBiz3.SendKeys(shareholderLastNameBiz3);

            // enter business shareholder > individual number of voting shares
            NgWebElement uiIndyShareVotesBiz3 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-2']/div/section/app-org-structure/div[4]/section[1]/app-associate-list/div/table/tr/td[3]/app-field/section/div[1]/section/div/input"));
            uiIndyShareVotesBiz3.SendKeys(shareholderVotingSharesBiz3);

            // enter business shareholder > individual shareholder email
            NgWebElement uiIndyShareEmailBiz3 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-2']/div/section/app-org-structure/div[4]/section[1]/app-associate-list/div/table/tr/td[4]/app-field/section/div[1]/section/input"));
            uiIndyShareEmailBiz3.SendKeys(shareholderEmailBiz3);

            // enter business shareholder > individual shareholder DOB
            NgWebElement uiCalendarIndyS1Biz3 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-2']/div/section/app-org-structure/div[4]/section[1]/app-associate-list/div/table/tr/td[5]/app-field/section/div[1]/section/input"));
            uiCalendarIndyS1Biz3.Click();

            NgWebElement uiCalendarIndyS2Biz3 = ngDriver.FindElement(By.XPath("//*[@id='mat-datepicker-10']/div/mat-month-view/table/tbody/tr[2]/td[1]/div"));
            uiCalendarIndyS2Biz3.Click();
        }

        public void business_shareholder_4()
        {
            /********** Business Shareholder #4 **********/

            // create the business shareholder data
            string businessName4 = "Business Shareholder 4";
            string businessVotingShares4 = "2";
            string businessEmail4 = "businessshareholder4@email.com";

            // open business shareholder form
            NgWebElement uiOpenShareBiz4 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-2']/div/section/app-org-structure/div[4]/section[2]/app-associate-list/div/button"));
            uiOpenShareBiz4.Click();

            // enter business name
            NgWebElement uiShareFirstBiz4 = ngDriver.FindElement(By.XPath("(//input[@type='text'])[41]"));
            uiShareFirstBiz4.SendKeys(businessName4);

            // enter business voting shares
            NgWebElement uiShareVotesBiz4 = ngDriver.FindElement(By.XPath("(//input[@type='text'])[42]"));
            uiShareVotesBiz4.SendKeys(businessVotingShares4);

            // select the business type using dropdown
            NgWebElement uiShareBizType4 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-2']/div/section/app-org-structure/div[4]/section[2]/app-associate-list/div/table/tr/td[3]/app-field/section/div/section/select/option[2]"));
            uiShareBizType4.Click();

            // enter business shareholder email
            NgWebElement uiShareEmailBiz4 = ngDriver.FindElement(By.XPath("(//input[@type='text'])[43]"));
            uiShareEmailBiz4.SendKeys(businessEmail4);

            // select the business shareholder confirm button
            NgWebElement uiShareBizConfirmButton4 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-2']/div/section/app-org-structure/div[4]/section[2]/app-associate-list/div/table/tr/td[5]/i[1]/span"));
            uiShareBizConfirmButton4.Click();

            // find the upload test files in the bdd-tests\upload_files folder
            var environment = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(environment).Parent.FullName;
            string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;

            // upload a notice of articles document for business shareholder
            string noticeOfArticlesBiz4 = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "notice_of_articles.pdf");
            NgWebElement uploadNoticeofArticlesBiz4 = ngDriver.FindElement(By.XPath("(//input[@type='file'])[39]"));
            uploadNoticeofArticlesBiz4.SendKeys(noticeOfArticlesBiz4);

            // upload a central securities register document for business shareholder
            string centralSecuritiesRegisterBiz4 = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "central_securities_register.pdf");
            NgWebElement uploadCentralSecRegBiz4 = ngDriver.FindElement(By.XPath("(//input[@type='file'])[42]"));
            uploadCentralSecRegBiz4.SendKeys(centralSecuritiesRegisterBiz4);

            // upload a special rights and restrictions document for business shareholder
            string specialRightsRestrictionsBiz4 = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "special_rights_restrictions.pdf");
            NgWebElement uploadSpecialRightsResBiz4 = ngDriver.FindElement(By.XPath("(//input[@type='file'])[45]"));
            uploadSpecialRightsResBiz4.SendKeys(specialRightsRestrictionsBiz4);

            /********** Business Shareholder #4 - Key Personnel **********/

            // create business shareholder key personnel data
            string keyPersonnelFirstNameBiz4 = "KeyPersonnelBiz4First";
            string keyPersonnelLastNameBiz4 = "KeyPersonnelBiz4Last";
            string keyPersonnelTitleBiz4 = "KeyPersonnelBiz4Title";
            string keyPersonnelEmailBiz4 = "keypersonnel@biz4.com";

            // open business shareholder > key personnel form
            NgWebElement openKeyPersonnelFormBiz4 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-3']/div/section/app-org-structure/div[3]/section/app-associate-list/div/button"));
            openKeyPersonnelFormBiz4.Click();
        
            // enter business shareholder > key personnel first name
            NgWebElement uiKeyPersonFirstBiz4 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-3']/div/section/app-org-structure/div[3]/section/app-associate-list/div/table/tr/td[1]/app-field/section/div[1]/section/input"));
            uiKeyPersonFirstBiz4.SendKeys(keyPersonnelFirstNameBiz4);

            // enter business shareholder > key personnel last name
            NgWebElement uiKeyPersonLastBiz4 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-3']/div/section/app-org-structure/div[3]/section/app-associate-list/div/table/tr/td[2]/app-field/section/div[1]/section/input"));
            uiKeyPersonLastBiz4.SendKeys(keyPersonnelLastNameBiz4);

            // select business shareholder > key personnel role using checkbox
            NgWebElement uiKeyPersonRoleBiz4 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-3']/div/section/app-org-structure/div[3]/section/app-associate-list/div/table/tr/td[3]/app-field/section/div/section/table/tr/td[1]/input[1]"));
            uiKeyPersonRoleBiz4.Click();

            // enter business shareholder > key personnel title
            NgWebElement uiKeyPersonTitleBiz4 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-3']/div/section/app-org-structure/div[3]/section/app-associate-list/div/table/tr/td[4]/app-field/section/div/section/input"));
            uiKeyPersonTitleBiz4.SendKeys(keyPersonnelTitleBiz4);

            // enter business shareholder > key personnel email
            NgWebElement uiKeyPersonEmailBiz4 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-3']/div/section/app-org-structure/div[3]/section/app-associate-list/div/table/tr/td[5]/app-field/section/div[1]/section/input"));
            uiKeyPersonEmailBiz4.SendKeys(keyPersonnelEmailBiz4);

            // enter business shareholder > key personnel DOB
            NgWebElement uiKeyPersonnelDOB1Biz14 = ngDriver.FindElement(By.XPath("/html/body/app-root/div/div/div/main/div/app-multi-stage-application-flow/div/mat-horizontal-stepper/div[2]/div[2]/app-application-licensee-changes/div/section[1]/app-org-structure/div[5]/section[2]/app-associate-list/div/table/tr[2]/td/mat-expansion-panel/div/div/section/app-org-structure/div[4]/section[2]/app-associate-list/div/table/tr[2]/td/mat-expansion-panel/div/div/section/app-org-structure/div[4]/section[2]/app-associate-list/div/table/tr[2]/td/mat-expansion-panel/div/div/section/app-org-structure/div[4]/section[2]/app-associate-list/div/table/tr[2]/td/mat-expansion-panel/div/div/section/app-org-structure/div[3]/section/app-associate-list/div/table/tr/td[6]/app-field/section/div[1]/section/input"));
            uiKeyPersonnelDOB1Biz14.Click();

            NgWebElement uiKeyPersonnelDOB1Biz24 = ngDriver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/mat-datepicker-content/mat-calendar/div/mat-month-view/table/tbody/tr[2]/td[1]/div"));
            uiKeyPersonnelDOB1Biz24.Click();

            /********** Business Shareholder #4 - Individual Shareholder **********/

            // create the business shareholder > individual shareholder data
            string shareholderFirstNameBiz4 = "IndividualShareholderBiz4First";
            string shareholderLastNameBiz4 = "IndividualShareholderBiz4Last";
            string shareholderVotingSharesBiz4 = "1";
            string shareholderEmailBiz4 = "individualshareholder@biz4.com";

            // open business shareholder > individual shareholder form
            NgWebElement uiOpenIndyShareBiz4 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-3']/div/section/app-org-structure/div[4]/section[1]/app-associate-list/div/button"));
            uiOpenIndyShareBiz4.Click();

            // enter business shareholder > individual shareholder first name
            NgWebElement uiIndyShareFirstBiz4 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-3']/div/section/app-org-structure/div[4]/section[1]/app-associate-list/div/table/tr/td[1]/app-field/section/div[1]/section/input"));
            uiIndyShareFirstBiz4.SendKeys(shareholderFirstNameBiz4);

            // enter business shareholder > individual shareholder last name
            NgWebElement uiIndyShareLastBiz4 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-3']/div/section/app-org-structure/div[4]/section[1]/app-associate-list/div/table/tr/td[2]/app-field/section/div[1]/section/input"));
            uiIndyShareLastBiz4.SendKeys(shareholderLastNameBiz4);

            // enter business shareholder > individual number of voting shares
            NgWebElement uiIndyShareVotesBiz4 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-3']/div/section/app-org-structure/div[4]/section[1]/app-associate-list/div/table/tr/td[3]/app-field/section/div[1]/section/div/input"));
            uiIndyShareVotesBiz4.SendKeys(shareholderVotingSharesBiz4);

            // enter business shareholder > individual shareholder email
            NgWebElement uiIndyShareEmailBiz4 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-3']/div/section/app-org-structure/div[4]/section[1]/app-associate-list/div/table/tr/td[4]/app-field/section/div[1]/section/input"));
            uiIndyShareEmailBiz4.SendKeys(shareholderEmailBiz4);

            // enter business shareholder > individual shareholder DOB
            NgWebElement uiCalendarIndyS1Biz4 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-3']/div/section/app-org-structure/div[4]/section[1]/app-associate-list/div/table/tr/td[5]/app-field/section/div[1]/section/input"));
            uiCalendarIndyS1Biz4.Click();

            NgWebElement uiCalendarIndyS2Biz4 = ngDriver.FindElement(By.XPath("//*[@id='mat-datepicker-12']/div/mat-month-view/table/tbody/tr[2]/td[1]/div"));
            uiCalendarIndyS2Biz4.Click();
        }

        public void business_shareholder_5()
        {
            /********** Business Shareholder #5 **********/

            // create the business shareholder data
            string businessName5 = "Business Shareholder 5";
            string businessVotingShares5 = "1";
            string businessEmail5 = "businessshareholder5@email.com";

            // open business shareholder form
            NgWebElement uiOpenShareBiz5 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-3']/div/section/app-org-structure/div[4]/section[2]/app-associate-list/div/button"));
            uiOpenShareBiz5.Click();

            // enter business name
            NgWebElement uiShareFirstBiz5 = ngDriver.FindElement(By.XPath("(//input[@type='text'])[51]"));
            uiShareFirstBiz5.SendKeys(businessName5);

            // enter business voting shares
            NgWebElement uiShareVotesBiz5 = ngDriver.FindElement(By.XPath("(//input[@type='text'])[52]"));
            uiShareVotesBiz5.SendKeys(businessVotingShares5);

            // select the business type using dropdown
            NgWebElement uiShareBizType5 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-3']/div/section/app-org-structure/div[4]/section[2]/app-associate-list/div/table/tr/td[3]/app-field/section/div/section/select/option[2]"));
            uiShareBizType5.Click();

            // enter business shareholder email
            NgWebElement uiShareEmailBiz5 = ngDriver.FindElement(By.XPath("(//input[@type='text'])[53]"));
            uiShareEmailBiz5.SendKeys(businessEmail5);

            // select the business shareholder confirm button
            NgWebElement uiShareBizConfirmButton5 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-3']/div/section/app-org-structure/div[4]/section[2]/app-associate-list/div/table/tr/td[5]/i[1]/span"));
            uiShareBizConfirmButton5.Click();

            // find the upload test files in the bdd-tests\upload_files folder
            var environment = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(environment).Parent.FullName;
            string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;

            // upload a notice of articles document for business shareholder
            string noticeOfArticlesBiz5 = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "notice_of_articles.pdf");
            NgWebElement uploadNoticeofArticlesBiz5 = ngDriver.FindElement(By.XPath("(//input[@type='file'])[48]"));
            uploadNoticeofArticlesBiz5.SendKeys(noticeOfArticlesBiz5);

            // upload a central securities register document for business shareholder
            string centralSecuritiesRegisterBiz5 = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "central_securities_register.pdf");
            NgWebElement uploadCentralSecRegBiz5 = ngDriver.FindElement(By.XPath("(//input[@type='file'])[51]"));
            uploadCentralSecRegBiz5.SendKeys(centralSecuritiesRegisterBiz5);

            // upload a special rights and restrictions document for business shareholder
            string specialRightsRestrictionsBiz5 = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "special_rights_restrictions.pdf");
            NgWebElement uploadSpecialRightsResBiz5 = ngDriver.FindElement(By.XPath("(//input[@type='file'])[54]"));
            uploadSpecialRightsResBiz5.SendKeys(specialRightsRestrictionsBiz5);

            /********** Business Shareholder #5 - Key Personnel **********/

            // create business shareholder key personnel data
            string keyPersonnelFirstNameBiz5 = "KeyPersonnelBiz5First";
            string keyPersonnelLastNameBiz5 = "KeyPersonnelBiz5Last";
            string keyPersonnelTitleBiz5 = "KeyPersonnelBiz5Title";
            string keyPersonnelEmailBiz5 = "keypersonnel@biz5.com";

            // open business shareholder > key personnel form
            NgWebElement openKeyPersonnelFormBiz5 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-4']/div/section/app-org-structure/div[3]/section/app-associate-list/div/button"));
            openKeyPersonnelFormBiz5.Click();

            // enter business shareholder > key personnel first name
            NgWebElement uiKeyPersonFirstBiz5 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-4']/div/section/app-org-structure/div[3]/section/app-associate-list/div/table/tr/td[1]/app-field/section/div[1]/section/input"));
            uiKeyPersonFirstBiz5.SendKeys(keyPersonnelFirstNameBiz5);

            // enter business shareholder > key personnel last name
            NgWebElement uiKeyPersonLastBiz5 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-4']/div/section/app-org-structure/div[3]/section/app-associate-list/div/table/tr/td[2]/app-field/section/div[1]/section/input"));
            uiKeyPersonLastBiz5.SendKeys(keyPersonnelLastNameBiz5);

            // select business shareholder > key personnel role using checkbox
            NgWebElement uiKeyPersonRoleBiz5 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-4']/div/section/app-org-structure/div[3]/section/app-associate-list/div/table/tr/td[3]/app-field/section/div/section/table/tr/td[1]/input[1]"));
            uiKeyPersonRoleBiz5.Click();

            // enter business shareholder > key personnel title
            NgWebElement uiKeyPersonTitleBiz5 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-4']/div/section/app-org-structure/div[3]/section/app-associate-list/div/table/tr/td[4]/app-field/section/div/section/input"));
            uiKeyPersonTitleBiz5.SendKeys(keyPersonnelTitleBiz5);

            // enter business shareholder > key personnel email
            NgWebElement uiKeyPersonEmailBiz5 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-4']/div/section/app-org-structure/div[3]/section/app-associate-list/div/table/tr/td[5]/app-field/section/div[1]/section/input"));
            uiKeyPersonEmailBiz5.SendKeys(keyPersonnelEmailBiz5);

            // enter business shareholder > key personnel DOB
            NgWebElement uiKeyPersonnelDOB1Biz15 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-4']/div/section/app-org-structure/div[3]/section/app-associate-list/div/table/tr/td[6]/app-field/section/div[1]/section/input"));
            uiKeyPersonnelDOB1Biz15.Click();

            NgWebElement uiKeyPersonnelDOB1Biz25 = ngDriver.FindElement(By.XPath("//html/body/div[2]/div[2]/div/mat-datepicker-content/mat-calendar/div/mat-month-view/table/tbody/tr[2]/td[1]/div"));
            uiKeyPersonnelDOB1Biz25.Click();

            /********** Business Shareholder #5 - Individual Shareholder **********/

            // create the business shareholder > individual shareholder data
            string shareholderFirstNameBiz5 = "IndividualShareholderBiz5First";
            string shareholderLastNameBiz5 = "IndividualShareholderBiz5Last";
            string shareholderVotingSharesBiz5 = "1";
            string shareholderEmailBiz5 = "individualshareholder@biz5.com";

            // open business shareholder > individual shareholder form
            NgWebElement uiOpenIndyShareBiz5 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-4']/div/section/app-org-structure/div[4]/section[1]/app-associate-list/div/button"));
            uiOpenIndyShareBiz5.Click();

            // enter business shareholder > individual shareholder first name
            NgWebElement uiIndyShareFirstBiz5 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-4']/div/section/app-org-structure/div[4]/section[1]/app-associate-list/div/table/tr/td[1]/app-field/section/div[1]/section/input"));
            uiIndyShareFirstBiz5.SendKeys(shareholderFirstNameBiz5);

            // enter business shareholder > individual shareholder last name
            NgWebElement uiIndyShareLastBiz5 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-4']/div/section/app-org-structure/div[4]/section[1]/app-associate-list/div/table/tr/td[2]/app-field/section/div[1]/section/input"));
            uiIndyShareLastBiz5.SendKeys(shareholderLastNameBiz5);

            // enter business shareholder > individual number of voting shares
            NgWebElement uiIndyShareVotesBiz5 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-4']/div/section/app-org-structure/div[4]/section[1]/app-associate-list/div/table/tr/td[3]/app-field/section/div[1]/section/div/input"));
            uiIndyShareVotesBiz5.SendKeys(shareholderVotingSharesBiz5);

            // enter business shareholder > individual shareholder DOB
            NgWebElement uiCalendarIndyS1Biz5 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-4']/div/section/app-org-structure/div[4]/section[1]/app-associate-list/div/table/tr/td[5]/app-field/section/div[1]/section/input"));
            uiCalendarIndyS1Biz5.Click();

            NgWebElement uiCalendarIndyS2Biz5 = ngDriver.FindElement(By.XPath("//*[@id='mat-datepicker-14']/div/mat-month-view/table/tbody/tr[2]/td[1]/div"));
            uiCalendarIndyS2Biz5.Click();

            // enter business shareholder > individual shareholder email
            NgWebElement uiIndyShareEmailBiz5 = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-4']/div/section/app-org-structure/div[4]/section[1]/app-associate-list/div/table/tr/td[4]/app-field/section/div[1]/section/input"));
            uiIndyShareEmailBiz5.SendKeys(shareholderEmailBiz5);

            // click on the Confirm button
            //NgWebElement uiClickConfirmButton = ngDriver.FindElement(By.XPath("//*[@id='cdk-accordion-child-4']/div/section/app-org-structure/div[4]/section[1]/app-associate-list/div/table/tr/td[6]/i[1]/span"));
            //uiClickConfirmButton.Click();
        }
    }
}
