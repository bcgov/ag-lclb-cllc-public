﻿using System;
using OpenQA.Selenium;
using Xunit.Gherkin.Quick;

namespace bdd_tests
{
    public abstract partial class TestBase : Feature, IDisposable
    {
        [Given(@"I click on the Swagger link for OneStop")]
        public void ClickOnSwaggerLink()
        {
            ngDriver.IgnoreSynchronization = true;
            ngDriver.WrappedDriver.Navigate()
                .GoToUrl("https://one-stop-testing-b7aa30-dev.apps.silver.devops.gov.bc.ca/swagger/index.html");
        }


        [And(@"I click on the SwaggerUI (.*)")]
        public void ClickOnSwaggerButton(string buttonType)
        {
            /********************
             *  Authorize buttons
             ********************/

            if (buttonType == "Authorize button")
            {
                IWebElement uiButton = ngDriver.FindElement(By.CssSelector("button.authorize"));
                var executor = (IJavaScriptExecutor) ngDriver.WrappedDriver;
                executor.ExecuteScript("arguments[0].click();", uiButton);
            }

            if (buttonType == "second Authorize button")
            {
                IWebElement uiButton = ngDriver.FindElement(By.CssSelector("button.authorize.button"));
                var executor = (IJavaScriptExecutor) ngDriver.WrappedDriver;
                executor.ExecuteScript("arguments[0].click();", uiButton);
            }

            /*******************
            *  Close button
            *******************/

            if (buttonType == "Close button")
            {
                IWebElement uiButton = ngDriver.FindElement(By.CssSelector("button.btn-done"));
                var executor = (IJavaScriptExecutor) ngDriver.WrappedDriver;
                executor.ExecuteScript("arguments[0].click();", uiButton);
            }

            /*******************
            *  Get buttons
            *******************/

            if (buttonType == "Get button for SendChangeAddress")
            {
                IWebElement uiButton = ngDriver.FindElement(By.XPath(
                    "/html/body/div[1]/section/div[2]/div[2]/div[4]/section/div/span[2]/div/div/span[2]/div/div/span[1]"));
                //#operations-OneStop-OneStop_GET
                var executor = (IJavaScriptExecutor) ngDriver.WrappedDriver;
                executor.ExecuteScript("arguments[0].click();", uiButton);
            }

            if (buttonType == "Get button for SendChangeName")
            {
                IWebElement uiButton =
                    ngDriver.FindElement(By.CssSelector("span:nth-child(3) .opblock-summary-method"));
                var executor = (IJavaScriptExecutor) ngDriver.WrappedDriver;
                executor.ExecuteScript("arguments[0].click();", uiButton);
            }

            if (buttonType == "Get button for SendChangeStatus")
            {
                IWebElement uiButton =
                    ngDriver.FindElement(By.CssSelector("span:nth-child(4) .opblock-summary-method"));
                var executor = (IJavaScriptExecutor) ngDriver.WrappedDriver;
                executor.ExecuteScript("arguments[0].click();", uiButton);
            }

            if (buttonType == "Get button for SendLicenceCreationMessage")
            {
                IWebElement uiButton =
                    ngDriver.FindElement(By.CssSelector("span:nth-child(5) .opblock-summary-method"));
                var executor = (IJavaScriptExecutor) ngDriver.WrappedDriver;
                executor.ExecuteScript("arguments[0].click();", uiButton);
            }

            if (buttonType == "Get button for SendProgramAccountDetailsBroadcastMessage")
            {
                IWebElement uiButton =
                    ngDriver.FindElement(By.CssSelector("span:nth-child(6) .opblock-summary-method"));
                var executor = (IJavaScriptExecutor) ngDriver.WrappedDriver;
                executor.ExecuteScript("arguments[0].click();", uiButton);
            }

            /********************
            *  Try it out buttons
            ********************/

            if (buttonType == "Try it out button for SendChangeAddress")
            {
                IWebElement uiButton = ngDriver.FindElement(By.XPath(
                    "/html/body/div/section/div[2]/div[2]/div[4]/section/div/span[2]/div/div/span[1]/div/div[2]/div/div[1]/div[1]/div[2]/button"));
                var executor = (IJavaScriptExecutor) ngDriver.WrappedDriver;
                executor.ExecuteScript("arguments[0].click();", uiButton);
            }

            if (buttonType == "Try it out button for SendChangeName")
            {
                IWebElement uiButton = ngDriver.FindElement(By.XPath(""));
                var executor = (IJavaScriptExecutor) ngDriver.WrappedDriver;
                executor.ExecuteScript("arguments[0].click();", uiButton);
            }

            if (buttonType == "Try it out button for SendChangeStatus")
            {
                IWebElement uiButton = ngDriver.FindElement(By.XPath(""));
                var executor = (IJavaScriptExecutor) ngDriver.WrappedDriver;
                executor.ExecuteScript("arguments[0].click();", uiButton);
            }

            if (buttonType == "Try it out button for SendLicenceCreationMessage")
            {
                IWebElement uiButton = ngDriver.FindElement(By.XPath(""));
                var executor = (IJavaScriptExecutor) ngDriver.WrappedDriver;
                executor.ExecuteScript("arguments[0].click();", uiButton);
            }

            if (buttonType == "Try it out button for SendProgramAccountDetailsBroadcastMessage")
            {
                IWebElement uiButton = ngDriver.FindElement(By.XPath(""));
                var executor = (IJavaScriptExecutor) ngDriver.WrappedDriver;
                executor.ExecuteScript("arguments[0].click();", uiButton);
            }

            /********************
            *  Execute button
            ********************/

            if (buttonType == "Execute button")
            {
                IWebElement uiButton = ngDriver.FindElement(By.CssSelector("button.execute"));
                var executor = (IJavaScriptExecutor) ngDriver.WrappedDriver;
                executor.ExecuteScript("arguments[0].click();", uiButton);
            }

            /********************
            *  Clear button
            ********************/

            if (buttonType == "Clear button")
            {
                IWebElement uiButton = ngDriver.FindElement(By.CssSelector("button.btn-clear"));
                var executor = (IJavaScriptExecutor) ngDriver.WrappedDriver;
                executor.ExecuteScript("arguments[0].click();", uiButton);
            }
        }

        [And(@"I enter the licence GUID for (.*)")]
        public void EnterLicenceGUID(string scenario)
        {
            if (scenario == "SendChangeAddress")
            {
                IWebElement uiEnterGUID = ngDriver.FindElement(By.XPath(
                    "/html/body/div[1]/section/div[2]/div[2]/div[4]/section/div/span[2]/div/div/span[2]/div/div[2]/div/div[1]/div[2]/div/table/tbody/tr/td[2]/input"));
                var executor = (IJavaScriptExecutor) ngDriver.WrappedDriver;
                executor.ExecuteScript("arguments[0].value='0B658594-6A03-EB11-B81E-00505683FBF4';", uiEnterGUID);
            }

            if (scenario == "SendChangeName")
            {
                IWebElement uiEnterGUID = ngDriver.FindElement(By.XPath(""));
                var executor = (IJavaScriptExecutor) ngDriver.WrappedDriver;
                executor.ExecuteScript("arguments[0].value='0B658594-6A03-EB11-B81E-00505683FBF4';", uiEnterGUID);
            }

            if (scenario == "SendChangeStatus")
            {
                IWebElement uiEnterGUID = ngDriver.FindElement(By.XPath(""));
                var executor = (IJavaScriptExecutor) ngDriver.WrappedDriver;
                executor.ExecuteScript("arguments[0].value='0B658594-6A03-EB11-B81E-00505683FBF4';", uiEnterGUID);
            }

            if (scenario == "SendLicenceCreationMessage")
            {
                IWebElement uiEnterGUID = ngDriver.FindElement(By.XPath(""));
                var executor = (IJavaScriptExecutor) ngDriver.WrappedDriver;
                executor.ExecuteScript("arguments[0].value='0B658594-6A03-EB11-B81E-00505683FBF4';", uiEnterGUID);
            }

            if (scenario == "SendProgramAccountDetailsBroadcastMessage")
            {
                IWebElement uiEnterGUID = ngDriver.FindElement(By.XPath(""));
                var executor = (IJavaScriptExecutor) ngDriver.WrappedDriver;
                executor.ExecuteScript("arguments[0].value='0B658594-6A03-EB11-B81E-00505683FBF4';", uiEnterGUID);
            }
        }


        [And(@"the correct 200 response is displayed")]
        public void CorrectResponse2()
        {
            // to be updated
            // Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'200')]")).Displayed);
        }
    }
}