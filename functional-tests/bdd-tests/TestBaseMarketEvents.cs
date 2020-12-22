﻿using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using Protractor;
using System;
using Xunit;
using Xunit.Abstractions;
using Xunit.Gherkin.Quick;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace bdd_tests
{
    public abstract partial class TestBase : Feature, IDisposable
    {
        [And(@"I request a market event (.*)")]
        public void MarketEvents(string frequency)
        {
            /* 
            Page Title: Licences & Authorizations
            */

            // refresh page required for link display
            ngDriver.Navigate().Refresh();

            string marketEvent = "Request Market Event Authorization";

            // click on the Request Market Event Authorization link
            NgWebElement uiOnSiteStoreEndorsement = ngDriver.FindElement(By.LinkText(marketEvent));
            uiOnSiteStoreEndorsement.Click();

            /* 
            Page Title: Market Authorization Request
            */

            // create test data
            string contactName = "Test Automation";
            string contactPhoneNumber = "(222) 222-2222";
            string contactEmail = "test@automation.com";
            string marketName = "Point Ellis Market";
            string marketWebsite = "http://www.pointellismarketisamazing.com";
            string bizLegalName = "Point Ellis Market Cooperative";
            string marketBizNumber = "2222222222222222";
            string incorporationNumber = "1234567";
            string address1 = "645 Tyee Road";
            string address2 = "West";
            string city = "Victoria";
            string postalCode = "V9A 6X5";
            string additionalDetails = "Additional details for automated test.";
            string additionalInformation = "Additional information for automated test.";

            // select preventing sale of liquor checkbox
            NgWebElement uiPreventingSaleOfLiquor = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='isNoPreventingSaleofLiquor']"));
            uiPreventingSaleOfLiquor.Click();

            // select market managed or carried checkbox
            NgWebElement uiMarketManagedOrCarried = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='isMarketManagedorCarried']"));
            uiMarketManagedOrCarried.Click();

            // select market only vendors checkbox
            NgWebElement uiIsMarketOnlyVendors = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='isMarketOnlyVendors']"));
            uiIsMarketOnlyVendors.Click();

            // select imported goods checkbox
            NgWebElement uiIsNoImportedGoods = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='isNoImportedGoods']"));
            uiIsNoImportedGoods.Click();

            // select six vendors checkbox
            NgWebElement uiIsMarketHostsSixVendors = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='isMarketHostsSixVendors']"));
            uiIsMarketHostsSixVendors.Click();

            // select max amount or duration checkbox
            NgWebElement uiIsMarketMaxAmountorDuration = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='isMarketMaxAmountorDuration']"));
            uiIsMarketMaxAmountorDuration.Click();

            // enter contact name
            NgWebElement uiContactName = ngDriver.FindElement(By.CssSelector("input[formcontrolname='contactName']"));
            uiContactName.SendKeys(contactName);

            // enter contact phone number
            NgWebElement uiContactPhoneNumber = ngDriver.FindElement(By.CssSelector("input[formcontrolname = 'contactPhone']"));
            uiContactPhoneNumber.SendKeys(contactPhoneNumber);

            // enter contact email
            NgWebElement uiContactEmail = ngDriver.FindElement(By.CssSelector("input[formcontrolname = 'contactEmail']"));
            uiContactEmail.SendKeys(contactEmail);

            // enter market name
            NgWebElement uiMarketName = ngDriver.FindElement(By.CssSelector("input[formcontrolname = 'marketName']"));
            uiMarketName.SendKeys(marketName);

            // enter market website
            NgWebElement uiMarketWebsite = ngDriver.FindElement(By.CssSelector("input[formcontrolname = 'marketWebsite']"));
            uiMarketWebsite.SendKeys(marketWebsite);

            // enter business legal name
            NgWebElement uiClientHostname = ngDriver.FindElement(By.CssSelector("input[formcontrolname = 'clientHostname']"));
            uiClientHostname.SendKeys(bizLegalName);

            // select market event type (annual)
            NgWebElement uiMarketEventType = ngDriver.FindElement(By.CssSelector("[formcontrolname= 'marketEventType'] option[value = '2: 845280002']"));
            uiMarketEventType.Click();

            // enter market business number
            NgWebElement uiBusinessNumber = ngDriver.FindElement(By.CssSelector("input[formcontrolname = 'businessNumber']"));
            uiBusinessNumber.SendKeys(marketBizNumber);

            // enter incorporation/registration number
            NgWebElement uiRegistrationNumber = ngDriver.FindElement(By.CssSelector("input[formcontrolname = 'registrationNumber']"));
            uiRegistrationNumber.SendKeys(incorporationNumber);

            // enter address 1
            NgWebElement uiStreet1 = ngDriver.FindElement(By.CssSelector("input[formcontrolname = 'street1']"));
            uiStreet1.SendKeys(address1);

            // enter address 2
            NgWebElement uiStreet2 = ngDriver.FindElement(By.CssSelector("input[formcontrolname = 'street2']"));
            uiStreet2.SendKeys(address2);

            // enter city
            NgWebElement uiCity = ngDriver.FindElement(By.CssSelector("input[formcontrolname = 'city']"));
            uiCity.SendKeys(city);

            // enter postal code
            NgWebElement uiPostalCode = ngDriver.FindElement(By.CssSelector("input[formcontrolname = 'postalCode']"));
            uiPostalCode.SendKeys(postalCode);

            // enter additional details
            NgWebElement uiAdditionalDetails = ngDriver.FindElement(By.CssSelector("textarea[formcontrolname='venueDescription']"));
            uiAdditionalDetails.SendKeys(additionalDetails);

            // select 'Once' from the frequency dropdown
            if (frequency == "for one date only")
            {
                // select frequency
                NgWebElement uiFrequency = ngDriver.FindElement(By.CssSelector("[formcontrolname='marketDuration'] option[value='3: 845280003']"));
                uiFrequency.Click();
            }

            // select 'Weekly' from the frequency dropdown
            if (frequency == "weekly")
            {
                // select frequency
                NgWebElement uiFrequency = ngDriver.FindElement(By.CssSelector("[formcontrolname='marketDuration'] option[value='0: 845280000']"));
                uiFrequency.Click();
            }

            // select 'Bi-Weekly' from the frequency dropdown
            if (frequency == "bi-weekly")
            {
                // select frequency
                NgWebElement uiFrequency = ngDriver.FindElement(By.CssSelector("[formcontrolname='marketDuration'] option[value='1: 845280001']"));
                uiFrequency.Click();
            }

            // select 'Monthly' from the frequency dropdown
            if (frequency == "monthly")
            {
                // select frequency
                NgWebElement uiFrequency = ngDriver.FindElement(By.CssSelector("[formcontrolname='marketDuration'] option[value='2: 845280002']"));
                uiFrequency.Click();
            }

            // enter additional information
            NgWebElement uiAdditionalInformation = ngDriver.FindElement(By.CssSelector("textarea[formcontrolname='additionalLocationInformation']"));
            uiAdditionalInformation.SendKeys(additionalInformation);

            // select end date
            NgWebElement uiEndDate1 = ngDriver.FindElement(By.CssSelector("input[formcontrolname='endDate']"));
            uiEndDate1.Click();

            // click on the next button
            NgWebElement uiOpenCalendarNext = ngDriver.FindElement(By.CssSelector(".mat-calendar .mat-calendar-next-button"));
            JavaScriptClick(uiOpenCalendarNext);

            if (frequency == "monthly")
            {
                // click on the next button again
                NgWebElement uiOpenCalendarNext2 = ngDriver.FindElement(By.CssSelector(".mat-calendar .mat-calendar-next-button"));
                JavaScriptClick(uiOpenCalendarNext2);
            }

            // click on the first day
            NgWebElement uiOpenCalendarYear = ngDriver.FindElement(By.CssSelector(".mat-calendar-content .mat-calendar-body-cell-content:first-child"));
            JavaScriptClick(uiOpenCalendarYear);

            // select start date
            NgWebElement uiStartDate1 = ngDriver.FindElement(By.CssSelector("input[formcontrolname='startDate']"));
            uiStartDate1.Click();

            try
            {
                NgWebElement uiStartDate2 = ngDriver.FindElement(By.CssSelector(".mat-calendar-body-cell-content.mat-calendar-body-today"));
                uiStartDate2.Click();
            }
            catch
            {
                // retry if failed once
                NgWebElement uiStartDate2 = ngDriver.FindElement(By.CssSelector(".mat-calendar-body-cell-content.mat-calendar-body-today"));
                uiStartDate2.Click();
            }

            if (frequency != "for one date only")
            {
                // confirm that all days are available for selection; de-selection is required due to days per week limit
                NgWebElement uiSunday = ngDriver.FindElement(By.CssSelector("#mat-checkbox-10 .mat-checkbox-inner-container"));
                JavaScriptClick(uiSunday);
                NgWebElement uiSunday2 = ngDriver.FindElement(By.CssSelector("#mat-checkbox-10 .mat-checkbox-inner-container"));
                JavaScriptClick(uiSunday2);

                NgWebElement uiMonday = ngDriver.FindElement(By.CssSelector("#mat-checkbox-11 .mat-checkbox-inner-container"));
                JavaScriptClick(uiMonday);
                NgWebElement uiMonday2 = ngDriver.FindElement(By.CssSelector("#mat-checkbox-11 .mat-checkbox-inner-container"));
                JavaScriptClick(uiMonday2);

                NgWebElement uiTuesday = ngDriver.FindElement(By.CssSelector("#mat-checkbox-12 .mat-checkbox-inner-container"));
                JavaScriptClick(uiTuesday);
                NgWebElement uiTuesday2 = ngDriver.FindElement(By.CssSelector("#mat-checkbox-12 .mat-checkbox-inner-container"));
                JavaScriptClick(uiTuesday2);

                NgWebElement uiWednesday = ngDriver.FindElement(By.CssSelector("#mat-checkbox-13 .mat-checkbox-inner-container"));
                JavaScriptClick(uiWednesday);
                NgWebElement uiWednesday2 = ngDriver.FindElement(By.CssSelector("#mat-checkbox-13 .mat-checkbox-inner-container"));
                JavaScriptClick(uiWednesday2);

                NgWebElement uiThursday = ngDriver.FindElement(By.CssSelector("#mat-checkbox-14 .mat-checkbox-inner-container"));
                JavaScriptClick(uiThursday);
                NgWebElement uiThursday2 = ngDriver.FindElement(By.CssSelector("#mat-checkbox-14 .mat-checkbox-inner-container"));
                JavaScriptClick(uiThursday2);

                NgWebElement uiFriday = ngDriver.FindElement(By.CssSelector("#mat-checkbox-15 .mat-checkbox-inner-container"));
                JavaScriptClick(uiFriday);
                NgWebElement uiFriday2 = ngDriver.FindElement(By.CssSelector("#mat-checkbox-15 .mat-checkbox-inner-container"));
                JavaScriptClick(uiFriday2);

                NgWebElement uiSaturday = ngDriver.FindElement(By.CssSelector("#mat-checkbox-16 .mat-checkbox-inner-container"));
                JavaScriptClick(uiSaturday);
                NgWebElement uiSaturday2 = ngDriver.FindElement(By.CssSelector("#mat-checkbox-16 .mat-checkbox-inner-container"));
                JavaScriptClick(uiSaturday2);

                if ((frequency == "weekly") || (frequency == "bi-weekly"))
                {
                    // make final selection re days of the week
                    NgWebElement uiThursdayFinal = ngDriver.FindElement(By.CssSelector("#mat-checkbox-14 .mat-checkbox-inner-container"));
                    JavaScriptClick(uiThursdayFinal);

                    NgWebElement uiFridayFinal = ngDriver.FindElement(By.CssSelector("#mat-checkbox-15 .mat-checkbox-inner-container"));
                    JavaScriptClick(uiFridayFinal);

                    NgWebElement uiSaturdayFinal = ngDriver.FindElement(By.CssSelector("#mat-checkbox-16 .mat-checkbox-inner-container"));
                    JavaScriptClick(uiSaturdayFinal);
                }

                if (frequency == "monthly")
                {
                    // select day of the week
                    NgWebElement uiSaturday3 = ngDriver.FindElement(By.CssSelector("#mat-checkbox-16 .mat-checkbox-inner-container"));
                    JavaScriptClick(uiSaturday3);

                    // select first week of the month
                    NgWebElement uiWeekOfMonth1 = ngDriver.FindElement(By.CssSelector("[formcontrolname='weekOfMonth'] [for='mat-radio-2-input']"));
                    JavaScriptClick(uiWeekOfMonth1);

                    // select second week of the month
                    NgWebElement uiWeekOfMonth2 = ngDriver.FindElement(By.CssSelector("[formcontrolname='weekOfMonth'] [for='mat-radio-3-input']"));
                    JavaScriptClick(uiWeekOfMonth2);

                    // select third week of the month
                    NgWebElement uiWeekOfMonth3 = ngDriver.FindElement(By.CssSelector("[formcontrolname='weekOfMonth'] [for='mat-radio-4-input']"));
                    JavaScriptClick(uiWeekOfMonth3);

                    // select fourth week of the month
                    NgWebElement uiWeekOfMonth4 = ngDriver.FindElement(By.CssSelector("[formcontrolname='weekOfMonth'] [for='mat-radio-5-input']"));
                    JavaScriptClick(uiWeekOfMonth4);
                }
            }

            // decrement event start hour
            NgWebElement uiEventStartHour = ngDriver.FindElement(By.CssSelector("[formcontrolname='startTime'] .ngb-tp-hour [type='button'] span.bottom"));
            JavaScriptClick(uiEventStartHour);

            // decrement event start minute
            NgWebElement uiEventStartMinute = ngDriver.FindElement(By.CssSelector("[formcontrolname='startTime'] .ngb-tp-minute span.ngb-tp-chevron.bottom"));
            JavaScriptClick(uiEventStartMinute);

            // decrement event end hour
            NgWebElement uiEventEndHour = ngDriver.FindElement(By.CssSelector("[formcontrolname='endTime'] .ngb-tp-hour [type='button'] span.bottom"));
            JavaScriptClick(uiEventEndHour);

            // decrement event end minute
            NgWebElement uiEventEndMinute = ngDriver.FindElement(By.CssSelector("[formcontrolname='endTime'] .ngb-tp-minute [type='button'] span.bottom"));
            JavaScriptClick(uiEventEndMinute);

            // increment liquor sale start hour
            NgWebElement uiLiquorStartHour = ngDriver.FindElement(By.CssSelector(".col-md-2:nth-child(4) .ngb-tp-hour .ng-star-inserted:nth-child(1) .ngb-tp-chevron"));
            JavaScriptClick(uiLiquorStartHour);

            // increment liquor sale start minute
            NgWebElement uiLiquorStartMinute = ngDriver.FindElement(By.CssSelector(".col-md-2:nth-child(4) .ngb-tp-minute .ng-star-inserted:nth-child(1) .ngb-tp-chevron"));
            JavaScriptClick(uiLiquorStartMinute);

            // double decrement liquor sale end hour
            NgWebElement uiLiquorEndHour1 = ngDriver.FindElement(By.CssSelector("[formcontrolname='liquorEndTime'] .ngb-tp-hour span.bottom"));
            JavaScriptClick(uiLiquorEndHour1);
            JavaScriptClick(uiLiquorEndHour1);

            // double decrement liquor sale end minute
            NgWebElement uiLiquorEndMinute1 = ngDriver.FindElement(By.CssSelector("[formcontrolname='liquorEndTime'] .ngb-tp-minute span.bottom"));
            JavaScriptClick(uiLiquorEndMinute1);
            JavaScriptClick(uiLiquorEndMinute1);

            // select agreement checkbox
            NgWebElement uiAgreement = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='agreement']"));
            uiAgreement.Click();

            // select serving it right/minors checkbox
            NgWebElement uiServingItRight = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='isAllStaffServingitRight']"));
            uiServingItRight.Click();

            // select sample sizes checkbox
            NgWebElement uiSampleSizes = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='isSampleSizeCompliant']"));
            uiSampleSizes.Click();
        }


        [And(@"I click on the market event save button")]
        public void MarketEventsSave()
        {
            NgWebElement uiSaveForLater = ngDriver.FindElement(By.CssSelector(".btn-primary:nth-child(1)"));
            uiSaveForLater.Click();
        }


        [And(@"I click on the event history for markets")]
        public void MarketEventsHistory()
        {
            NgWebElement uiExpandEventHistory = ngDriver.FindElement(By.CssSelector("mat-expansion-panel-header[role='button'] #expand-history-button-0"));
            uiExpandEventHistory.Click();
        }


        [And(@"the market event data is correct for (.*)")]
        public void MarketEventDataCorrect(string frequency)
        {
            // confirm preventing sale of liquor checkbox is selected
            NgWebElement uiPreventingSaleOfLiquor = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='isNoPreventingSaleofLiquor']"));
            Assert.Contains("mat-checkbox-checked", uiPreventingSaleOfLiquor.GetAttribute("class"));

            // confirm market managed or carried checkbox is selected
            NgWebElement uiMarketManagedOrCarried = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='isMarketManagedorCarried']"));
            Assert.Contains("mat-checkbox-checked", uiMarketManagedOrCarried.GetAttribute("class"));

            // confirm market only vendors checkbox is selected
            NgWebElement uiIsMarketOnlyVendors = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='isMarketOnlyVendors']"));
            Assert.Contains("mat-checkbox-checked", uiIsMarketOnlyVendors.GetAttribute("class"));

            // confirm imported goods checkbox is selected
            NgWebElement uiIsNoImportedGoods = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='isNoImportedGoods']"));
            Assert.Contains("mat-checkbox-checked", uiIsNoImportedGoods.GetAttribute("class"));

            // confirm six vendors checkbox is selected
            NgWebElement uiIsMarketHostsSixVendors = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='isMarketHostsSixVendors']"));
            Assert.Contains("mat-checkbox-checked", uiIsMarketHostsSixVendors.GetAttribute("class"));

            // confirm max amount or duration checkbox is selected
            NgWebElement uiIsMarketMaxAmountorDuration = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='isMarketMaxAmountorDuration']"));
            Assert.Contains("mat-checkbox-checked", uiIsMarketMaxAmountorDuration.GetAttribute("class"));

            // confirm contact name is correct
            NgWebElement uiContactName = ngDriver.FindElement(By.CssSelector("input[formcontrolname='contactName']"));
            Assert.True(uiContactName.GetAttribute("value") == "Test Automation");

            // confirm contact phone number is correct
            NgWebElement uiContactPhoneNumber = ngDriver.FindElement(By.CssSelector("input[formcontrolname = 'contactPhone']"));
            Assert.True(uiContactPhoneNumber.GetAttribute("value") == "(222) 222-2222");

            // confirm contact email is correct
            NgWebElement uiContactEmail = ngDriver.FindElement(By.CssSelector("input[formcontrolname = 'contactEmail']"));
            Assert.True(uiContactEmail.GetAttribute("value") == "test@automation.com");

            // confirm market name is correct
            NgWebElement uiMarketName = ngDriver.FindElement(By.CssSelector("input[formcontrolname = 'marketName']"));
            Assert.True(uiMarketName.GetAttribute("value") == "Point Ellis Market");

            // confirm market website is correct
            NgWebElement uiMarketWebsite = ngDriver.FindElement(By.CssSelector("input[formcontrolname = 'marketWebsite']"));
            Assert.True(uiMarketWebsite.GetAttribute("value") == "http://www.pointellismarketisamazing.com");

            // confirm business legal name is correct
            NgWebElement uiClientHostname = ngDriver.FindElement(By.CssSelector("input[formcontrolname = 'clientHostname']"));
            Assert.True(uiClientHostname.GetAttribute("value") == "Point Ellis Market Cooperative");

            // confirm market event type is correct
            NgWebElement uiMarketEventType = ngDriver.FindElement(By.CssSelector("[formcontrolname= 'marketEventType']"));
            Assert.True(uiMarketEventType.GetAttribute("value") == "2: 845280002");

            // confirm market business number is correct
            NgWebElement uiBusinessNumber = ngDriver.FindElement(By.CssSelector("input[formcontrolname = 'businessNumber']"));
            Assert.True(uiBusinessNumber.GetAttribute("value") == "2222222222222222");

            // confirm incorporation/registration number is correct
            NgWebElement uiRegistrationNumber = ngDriver.FindElement(By.CssSelector("input[formcontrolname = 'registrationNumber']"));
            Assert.True(uiRegistrationNumber.GetAttribute("value") == "1234567");

            // confirm address 1 is correct
            NgWebElement uiStreet1 = ngDriver.FindElement(By.CssSelector("input[formcontrolname = 'street1']"));
            Assert.True(uiStreet1.GetAttribute("value") == "645 Tyee Road");

            // confirm address 2 is correct
            NgWebElement uiStreet2 = ngDriver.FindElement(By.CssSelector("input[formcontrolname = 'street2']"));
            Assert.True(uiStreet2.GetAttribute("value") == "West");

            // confirm city is correct
            NgWebElement uiCity = ngDriver.FindElement(By.CssSelector("input[formcontrolname = 'city']"));
            Assert.True(uiCity.GetAttribute("value") == "Victoria");

            // confirm postal code is correct
            NgWebElement uiPostalCode = ngDriver.FindElement(By.CssSelector("input[formcontrolname = 'postalCode']"));
            Assert.True(uiPostalCode.GetAttribute("value") == "V9A 6X5");

            // confirm additional details are correct
            NgWebElement uiAdditionalDetails = ngDriver.FindElement(By.CssSelector("textarea[formcontrolname='venueDescription']"));
            Assert.True(uiAdditionalDetails.GetAttribute("value") == "Additional details for automated test.");
 
            if ((frequency == "a one day event") || (frequency == "one day event saved for later"))
            {
                NgWebElement uiFrequency = ngDriver.FindElement(By.CssSelector("[formcontrolname='marketDuration']"));
                Assert.True(uiFrequency.GetAttribute("value") == "3: 845280003");
            }

            if ((frequency == "a weekly event") || (frequency == "a weekly event saved for later"))
            {
                NgWebElement uiFrequency = ngDriver.FindElement(By.CssSelector("[formcontrolname='marketDuration']"));
                Assert.True(uiFrequency.GetAttribute("value") == "0: 845280000");
            }

            if ((frequency == "a monthly event") || (frequency == "a monthly event saved for later"))
            {
                NgWebElement uiFrequency = ngDriver.FindElement(By.CssSelector("[formcontrolname='marketDuration']"));
                Assert.True(uiFrequency.GetAttribute("value") == "2: 845280002");
            }

            if ((frequency == "a bi-weekly event") || (frequency == "a bi-weekly event saved for later"))
            {
                NgWebElement uiFrequency = ngDriver.FindElement(By.CssSelector("[formcontrolname='marketDuration']"));
                Assert.True(uiFrequency.GetAttribute("value") == "1: 845280001");
            }

            // confirm additional information is correct
            NgWebElement uiAdditionalInformation = ngDriver.FindElement(By.CssSelector("textarea[formcontrolname='additionalLocationInformation']"));
            Assert.True(uiAdditionalInformation.GetAttribute("value") == "Additional information for automated test.");

            if ((frequency != "a one day event") || (frequency != "a one day event saved for later")) 
            {
                if ((frequency == "a weekly event") || (frequency == "a weekly event saved for later") || (frequency == "a bi-weekly event") || (frequency == "a bi-weekly event saved for later"))
                {
                    // confirm selection re days of the week
                    NgWebElement uiThursdayFinal = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='thursday']"));
                    Assert.Contains("mat-checkbox-checked", uiThursdayFinal.GetAttribute("class"));

                    NgWebElement uiFridayFinal = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='friday']"));
                    Assert.Contains("mat-checkbox-checked", uiFridayFinal.GetAttribute("class"));

                    NgWebElement uiSaturdayFinal = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='saturday']"));
                    Assert.Contains("mat-checkbox-checked", uiSaturdayFinal.GetAttribute("class"));
                }

                if ((frequency == "a monthly event") || (frequency == "a monthly event saved for later"))
                {
                    // confirm selected day of the week
                    NgWebElement uiSaturday3 = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='saturday']"));
                    Assert.Contains("mat-checkbox-checked", uiSaturday3.GetAttribute("class"));

                    // confirm selected week of the month
                    NgWebElement uiWeekOfMonth4 = ngDriver.FindElement(By.CssSelector("[formcontrolname='weekOfMonth'] mat-radio-button#mat-radio-10"));
                    Assert.Contains("mat-radio-checked", uiWeekOfMonth4.GetAttribute("class"));
                }

                if (frequency == "an approved monthly event")
                {
                    // confirm selected day of the week
                    NgWebElement uiSaturday3 = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='saturday']"));
                    Assert.Contains("mat-checkbox-checked", uiSaturday3.GetAttribute("class"));

                    // confirm selected week of the month
                    NgWebElement uiWeekOfMonth4 = ngDriver.FindElement(By.CssSelector("[formcontrolname='weekOfMonth'] mat-radio-button#mat-radio-10"));
                    Assert.Contains("mat-radio-checked", uiWeekOfMonth4.GetAttribute("class"));
                }
            }

            // confirm event start hour
            NgWebElement uiEventStartHour = ngDriver.FindElement(By.CssSelector("[formcontrolname='startTime'] input[aria-label='Hours']"));
            Assert.True(uiEventStartHour.GetAttribute("value") == "07");

            // confirm event start minute
            NgWebElement uiEventStartMinute = ngDriver.FindElement(By.CssSelector("[formcontrolname='startTime'] input[aria-label='Minutes']"));
            Assert.True(uiEventStartMinute.GetAttribute("value") == "59");

            // confirm event end hour
            NgWebElement uiEventEndHour = ngDriver.FindElement(By.CssSelector("[formcontrolname='endTime'] input[aria-label='Hours']"));
            Assert.True(uiEventEndHour.GetAttribute("value") == "09");

            // confirm event end minute
            NgWebElement uiEventEndMinute = ngDriver.FindElement(By.CssSelector("[formcontrolname='endTime'] input[aria-label='Minutes']"));
            Assert.True(uiEventEndMinute.GetAttribute("value") == "59");

            // confirm liquor sale start hour
            NgWebElement uiLiquorStartHour = ngDriver.FindElement(By.CssSelector("[formcontrolname='liquorStartTime'] input[aria-label='Hours']"));
            Assert.True(uiLiquorStartHour.GetAttribute("value") == "10");

            // confirm liquor sale start minute
            NgWebElement uiLiquorStartMinute = ngDriver.FindElement(By.CssSelector("[formcontrolname='liquorStartTime'] input[aria-label='Minutes']"));
            Assert.True(uiLiquorStartMinute.GetAttribute("value") == "01");

            // confirm liquor sale end hour
            NgWebElement uiLiquorEndHour1 = ngDriver.FindElement(By.CssSelector("[formcontrolname='liquorEndTime'] input[aria-label='Hours']"));
            Assert.True(uiLiquorEndHour1.GetAttribute("value") == "08");

            // confirm liquor sale end minute
            NgWebElement uiLiquorEndMinute1 = ngDriver.FindElement(By.CssSelector("[formcontrolname='liquorEndTime'] input[aria-label='Minutes']"));
            Assert.True(uiLiquorEndMinute1.GetAttribute("value") == "58");

            // confirm serving it right/minors checkbox is selected
            NgWebElement uiServingItRight = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='isAllStaffServingitRight']"));
            Assert.Contains("mat-checkbox-checked", uiServingItRight.GetAttribute("class"));

            // confirm sample sizes checkbox is selected
            NgWebElement uiSampleSizes = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='isSampleSizeCompliant']"));
            Assert.Contains("mat-checkbox-checked", uiSampleSizes.GetAttribute("class"));

            if ((frequency == "a one day event") || (frequency == "a weekly event") || (frequency == "a bi-weekly event") || (frequency == "a monthly event"))
            {
                // confirm agreement checkbox is selected
                NgWebElement uiAgreement = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='agreement']"));
                Assert.Contains("mat-checkbox-checked", uiAgreement.GetAttribute("class"));
            }

            // confirm that LCSD-4211 error is no longer happening
            Assert.True(ngDriver.FindElement(By.XPath("//body[not(contains(.,'Please enter the start date'))]")).Displayed);
        }


        [And(@"I click on the market event save for later button")]
        public void MarketEventSaveForLater()
        {
            NgWebElement uiSaveForLater = ngDriver.FindElement(By.CssSelector(".btn-primary:nth-child(1)"));
            uiSaveForLater.Click();
        }
    }
}
