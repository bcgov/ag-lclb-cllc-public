
using Gov.Lclb.Cllb.Interfaces;
using Gov.Lclb.Cllb.Public;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;
using static Gov.Lclb.Cllb.Interfaces.SharePointFileManager;

namespace SharePoint.Tests
{
    public class SharePoint 
    {

        IConfiguration Configuration;

        SharePointFileManager sharePointFileManager;

        string serverAppIdUri;

        /// <summary>
        /// Setup the test
        /// </summary>        
        public SharePoint()
        {
            Configuration = new ConfigurationBuilder()
                // The following line is the only reason we have a project reference for cllc-public-app.
                // If you were to use this code on a different project simply add user secrets as appropriate to match the environment / secret variables below.
                .AddUserSecrets<Startup>() // Add secrets from the cllc-public-app
                .AddEnvironmentVariables()
                .Build();

            serverAppIdUri = Configuration["SHAREPOINT_SERVER_APPID_URI"];
            string webname = Configuration["SHAREPOINT_WEBNAME"];
            string aadTenantId = Configuration["SHAREPOINT_AAD_TENANTID"];
            string clientId = Configuration["SHAREPOINT_CLIENT_ID"];
            string certFileName = Configuration["SHAREPOINT_CERTIFICATE_FILENAME"];
            string certPassword = Configuration["SHAREPOINT_CERTIFICATE_PASSWORD"];

            sharePointFileManager = new SharePointFileManager(serverAppIdUri, webname, aadTenantId, clientId, certFileName, certPassword, null, null);

        }

        /// <summary>
        /// Test GetFiles
        /// </summary>
        [Fact]
        public async void GetFilesTest()
        {
            var files = await sharePointFileManager.GetFiles();
            Assert.True(files != null);
        }

        /// <summary>
        /// Test GetFile
        /// </summary>
        [Fact]
        public async void GetFileTest()
        {
            var files = await sharePointFileManager.GetFiles();
            foreach (var file in files)
            {
                var temp = sharePointFileManager.GetFile(file.Url);
                Assert.True(temp != null);
            }

            Assert.True(files != null);
        }


        /// <summary>
        /// Test GetFile
        /// </summary>
        [Fact]
        public async void DownloadFileTest()
        {
            var files = await sharePointFileManager.GetFiles();
            foreach (var file in files)
            {
                var temp = sharePointFileManager.DownloadFile(file.Url);
                Assert.True(temp != null);
            }

            Assert.True(files != null);
        }

        [Fact]
        public async void UploadRemoveFilesTest()
        {
            Random rnd = new Random();
            string name = "test-name" + rnd.Next() +".txt";
            string testFolder = "test-folder" + rnd.Next();
            string listTitle = "Shared Documents";
            string url = serverAppIdUri + "/cannabisdev/Shared Documents/" + testFolder + "/" + name;
            
            string contentType = "text/plain";
            
            string testData = "This is just a test.";

            MemoryStream fileData = new MemoryStream(System.Text.Encoding.ASCII.GetBytes(testData));

            await sharePointFileManager.CreateFolder(listTitle, testFolder);

            await sharePointFileManager.UploadFile(name, "Shared Documents",testFolder, fileData, contentType);

            // now delete it.

            await sharePointFileManager.DeleteFile("Shared Documents", testFolder, name);

            // cleanup the test folder.
            await sharePointFileManager.DeleteFolder("Shared Documents", testFolder);
        }

        [Fact]
        public async void AddRemoveListFilesTest()
        {
            // set file and folder settings

            Random rnd = new Random();
            string fileName = "test-file-name" + rnd.Next() +".txt";
            string folderName = "test-folder-name" + rnd.Next();
            string path = "/" + sharePointFileManager.WebName + "/" + SharePointFileManager.DefaultDocumentListTitle + "/" + folderName + "/" + fileName;
            string url = serverAppIdUri + sharePointFileManager.WebName + "/" + SharePointFileManager.DefaultDocumentListTitle + "/" + folderName + "/" + fileName;
            string contentType = "text/plain";
            string testData = "This is just a test.";
            MemoryStream fileData = new MemoryStream(System.Text.Encoding.ASCII.GetBytes(testData));

            // add file to SP

            await sharePointFileManager.AddFile(folderName, fileName, fileData, contentType);

            // get file details list in SP folder

            List<FileDetailsList> fileDetailsList = await sharePointFileManager.GetFileDetailsListInFolder(SharePointFileManager.DefaultDocumentListTitle, folderName);
            //only one file should be returned
            Assert.Single(fileDetailsList);
            if (fileDetailsList != null)
            {
                foreach (FileDetailsList fileDetails in fileDetailsList)
                {
                    // validate that file name uploaded and listed are the same
                    Assert.Equal(fileName, fileDetails.Name);
                }
            }

            // verify that we can download the same file.

            byte[] data = await sharePointFileManager.DownloadFile(path);
            string stringData = System.Text.Encoding.ASCII.GetString(data);
            Assert.Equal(stringData, testData);

            // delete file from SP

            await sharePointFileManager.DeleteFile(SharePointFileManager.DefaultDocumentListTitle, folderName, fileName);

            // delete folder from SP

            await sharePointFileManager.DeleteFolder(SharePointFileManager.DefaultDocumentListTitle, folderName);
        }

        /// <summary>
        /// Test Create Folder
        /// </summary>
        [Fact]
        public async void InvalidFolderDoesNotExist()
        {
            Random rnd = new Random();
            string documentLocation = "Account";
            string folderName = "Test Folder" + rnd.Next() + "---" + rnd.Next();

            
            bool exists = await sharePointFileManager.FolderExists(documentLocation, folderName);

            Assert.False(exists);

        }

        /// <summary>
        /// Test Create Folder
        /// </summary>
        [Fact]
        public async void CreateFolderTest()
        {
            Random rnd = new Random();
            string documentLocation = "Account";
            string folderName = "Test Folder" + rnd.Next();

            SP.Folder folder = await sharePointFileManager.CreateFolder(documentLocation, folderName);

            Assert.True(folder != null);

            bool exists = await sharePointFileManager.FolderExists(documentLocation, folderName);

            Assert.True(exists);


            await sharePointFileManager.DeleteFolder(documentLocation, folderName);

            exists = await sharePointFileManager.FolderExists(documentLocation, folderName);

            Assert.False(exists);
        }

        [Fact]
        public async void GetFilesInEmptyFolderTest()
        {
            Random rnd = new Random();
            string documentList = "Documents";
            string folderName = "Test Folder" + rnd.Next();
            SP.Folder folder = await sharePointFileManager.CreateFolder(documentList, folderName);
            Assert.True(folder != null);
            var files = await sharePointFileManager.GetFilesInFolder(documentList, folderName);
            Assert.True(files != null);
            Assert.True(files.Count == 0);
            await sharePointFileManager.DeleteFolder(documentList, folderName);            
        }

        [Fact]
        public async void GetFilesInPopulatedFolderTest()
        {
            Random rnd = new Random();
            string documentList = "Documents";
            string folderName = "Test Folder" + rnd.Next();
            SP.Folder folder = await sharePointFileManager.CreateFolder(documentList, folderName);
            Assert.True(folder != null);
            var files = await sharePointFileManager.GetFilesInFolder(documentList, folderName);
            Assert.True(files != null);
            Assert.True(files.Count == 0);
            await sharePointFileManager.DeleteFolder(documentList, folderName);
        }

    }
}
