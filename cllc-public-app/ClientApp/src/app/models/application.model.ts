import { Account } from './account.model';
import { License } from './license.model';
import { Invoice } from './invoice.model';
import { ApplicationType } from './application-type.model';
import { TiedHouseConnection } from './tied-house-connection.model';

export class Application {
  id: string;
  account: Account;
  additionalPropertyInformation: string;
  applicantType: string;
  applicationStatus: string;
  applicationType: ApplicationType;
  applyingPerson: string;
  assignedLicence: License;
  authorizedToSubmit: boolean;
  contactPersonEmail: string;
  contactPersonFirstName: string;
  contactPersonLastName: string;
  contactPersonPhone: string;
  contactPersonRole: string;
  createdOn: Date;
  establishmentAddress: string;
  establishmentName: string;
  establishmentAddressCity: string;
  establishmentAddressPostalCode: string;
  establishmentAddressStreet: string;
  establishmentParcelId: string;
  establishmentPhone: string;
  isLocationChangeInProgress: boolean;
  isPaid: boolean;
  isSubmitted: boolean;
  jobNumber: string;
  licenceFeeInvoice: Invoice;
  licenceFeeInvoicePaid: boolean;
  licenseType: string;
  modifiedOn: Date;
  name: string;
  paymentReceivedDate: Date;
  registeredEstablishment: number;
  prevPaymentFailed: boolean;
  serviceHoursFridayClose: string;
  serviceHoursFridayOpen: string;
  serviceHoursMondayClose: string;
  serviceHoursMondayOpen: string;
  serviceHoursSaturdayClose: string;
  serviceHoursSaturdayOpen: string;
  serviceHoursSundayClose: string;
  serviceHoursSundayOpen: string;
  serviceHoursThursdayClose: string;
  serviceHoursThursdayOpen: string;
  serviceHoursTuesdayClose: string;
  serviceHoursTuesdayOpen: string;
  serviceHoursWednesdayClose: string;
  serviceHoursWednesdayOpen: string;
  servicehHoursStandardHours: boolean;
  signatureAgreement: boolean;
  tiedHouse: TiedHouseConnection;
  indigenousNationId: string;
  federalProducerNames: string;

  checklistBrandingAssess: string;
  checklistEstabRenderAssessed: string;
  checklistFloorPlanAssess: string;
  checklistKeyPersonnelBuilt: string;
  checklistOrgLeadershipBuilt: string;
  checklistShareholdersBuilt: string;
  checklistSignageAssessed: string;
  checklistSiteMapAssess: string;
  checklistValidInterestAssess: string;
  checklistEstablishmentAddressAssessed: string;
}
