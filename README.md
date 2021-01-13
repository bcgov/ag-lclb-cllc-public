BC Liquor and Cannabis Regulation Branch - Liquor and Cannabis Licensing Application
======================
[![img](https://img.shields.io/badge/Lifecycle-Stable-97ca00)]

Technology Stack
-----------------

| Layer   | Technology | 
| ------- | ------------ |
| Presentation | Angular 10 |
| Business Logic | C Sharp - Dotnet Core 3.1 |
| Web Server | Nginx |
| Application Server | Kestrel |
| Data    | MS Dynamics On Premise V9, ADFS |
| Document Management    | MS SharePoint 2016, ADFS |   

Repository Map
--------------
- **.s2i**: Source to image (s2i) assembly script
- **agent-protractor**: Automated end to end tests 
- **cllc-interfaces**: Interface libraries for other systems:
  - BCeID
  - BC Express Pay (BCEP)
  - BC Registries
  - Microsoft Dynamics
  - Microsoft SharePoint
- **cllc-interfaces-test**: Automated tests for the above interface libraries
- **cllc-public-app**: Source code for the public facing application
- **cllc-public-app-test**: Automated tests for the public application
- **federal-reporting**: Image source for a service used to handle monthly reports to the federal government
- **file-manager**: Image source for a file manager used to handle communications with SharePoint
- **functional-tests**: Source for BDD tests
- **openshift**: Various OpenShift related material, including instructions for setup and templates.
- **pdf-service**: A PDF generator
- **sep-service**: Special Event Permit data collector
- **watchdog**: Image source for a watchdog that can monitor the dependency tree of the application

Installation
------------
This application is meant to be deployed to RedHat OpenShift version 4. Full instructions to deploy to OpenShift are in the `openshift` directory.

Developer Prerequisites
-----------------------

**Public Application**
- .Net Core SDK (3.1, 5.0)
- Node.js version 10.19 
- .NET Core IDE such as Visual Studio or VS Code
- JAG VPN with access to MS Dynamics

**DevOps**
- RedHat OpenShift tools
- Docker
- A familiarity with Jenkins

Microsoft Dynamics, SharePoint
---------------------------
A MS Dynamics instance containing the necessary solution files is required.  A SharePoint connection is optional.  If no SharePoint connection is available then file operations will not be executed.

Define the following secrets in your development environment (secrets or environment variables):
1. DYNAMICS_NATIVE_ODATA_URI: The URI to the Dynamics Web API endpoint.  Example:  `https://<hostname>/<tenant name>/api/data/v9.0/`.  This URI can be a proxy.
2. DYNAMICS_NATIVE_ODATA_URI: The native URI to the Dynamics Web API endpoint, in other words as the server identifies itself in responses to WebAPI requests.  Do not put a proxy URI here.
3. SSG_USERNAME: API gateway username, if using an API gateway
4. SSG_PASSWORD: API gateway password, if using an API gateway
5. DYNAMICS_AAD_TENANT_ID: ADFS Tenant ID, if using ADFS authentication.  Leave blank if using an API gateway
6. DYNAMICS_SERVER_APP_ID_URI: ADFS Server App ID URI. Leave blank if using an API gateway
7. DYNAMICS_CLIENT_ID: Public Key for the ADFS Enterprise Application app registration. Leave blank if using an API gateway
8. SHAREPOINT_ODATA_URI: Endpoint to be used for SharePoint, exclusive of _api.  Can be a proxy.  Leave blank if not using SharePoint.
9. SHAREPOINT_NATIVE_BASE_URI:  The SharePoint URI as configured in SharePoint.  Do not set to a proxy.
10. SHAREPOINT_SSG_USERNAME, SHAREPOINT_SSG_PASSWORD - optional API Gateway credentials for SharePoint
11. SharePoint may also use the same ADFS credentials as Dynamics.  If that is to be used, leave all SSG parameters empty or undefined.

Mac Environment
---------------
A Mac computer can be used for development.  The easiest way to prepare the Mac for development is to install Visual Studio 2019 for Mac.  

Prior to running the application for the first time, change directory to the "ClientApp" sub directory of cllc-public-app and execute `npm install`.  This will allow the node dependencies for the software to be downloaded.

A script `go-cllc.sh` has been provided to allow the application to be run on a mac.

Edit this file with the various settings you need to run the application.

If you wish to use a port other than 50001 for the app, change the last line to:

dotnet run --server.urls http://0.0.0.0:5000

(Where 5000 is your chosen port).


Note that for development purposes you should set ASPNETCORE_ENVIRONMENT to Development

(It can be set to Staging or Production after you execute a dotnet publish command to build static files)


DevOps Process
-------------

## Jenkins

If any pipeline steps do not start, a common root cause is problems with Jenkins.  Restart the Jenkins service by scaling it down to 0 pods, then back up to 1 pod.

## DEV builds
Dev builds are triggered by source code being committed to the repository.  This process triggers a webhook which initiates the DEV build pipeline.

Login to the OpenShift Web Console and navigate to the Tools project for the system, and view the status of the DEV portal pipeline build config to see the status of the build.

## TEST Builds
Merge code to the "master" branch.

TEST builds are triggered by source code being committed to the master branch of the repository.  This process triggers a webhook which initiates the TEST build pipeline.

Login to the OpenShift Web Console and navigate to the Tools project for the system, and view the status of the TEST portal pipeline build config to see the status of the build 

## Promotion to PROD
Login to the OpenShift Web Console and navigate to the Tools project for the system.  Go to the Build Config for the PROD Pipeline.  Click  Start Build. You will then have to CONFIRM the build by clicking on the related log item for the build that has been started.

Other
-----------

**SonarQube**

SonarQube is a code quality service that helps identify problem areas in code through static analysis.

The development pipeline, called during the OpenShift build process, includes a stage where the code is sent to SonarQube for analysis.


Contribution
------------

Please report any [issues](https://github.com/bcgov/jag-lcrb-carla-public/issues).

[Pull requests](https://github.com/bcgov/jag-lcrb-carla-public/pulls) are always welcome.

If you would like to contribute, please see our [contributing](CONTRIBUTING.md) guidelines.

Please note that this project is released with a [Contributor Code of Conduct](CODE_OF_CONDUCT.md). By participating in this project you agree to abide by its terms.

License
-------

    Copyright 2021 Province of British Columbia

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at 

       http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.

Maintenance
-----------

This repository is maintained by [BC Attorney General]( https://www2.gov.bc.ca/gov/content/governments/organizational-structure/ministries-organizations/ministries/justice-attorney-general ).

