import { Account } from './account.model';
import { License } from './license.model';
import { Invoice } from './invoice.model';
import { ApplicationType } from './application-type.model';
import { TiedHouseConnection } from './tied-house-connection.model';

export class Application {

  previousLicenceApplication: boolean;
  previousLicenceApplicationDetails: string;
  ruralAgencyStoreAppointment: boolean;
  liquorIndustryConnections: boolean;

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

  renewalCriminalOffenceCheck: string;
  renewalUnreportedSaleOfBusiness: string;
  renewalBusinessType: string;
  renewalTiedhouse: string;
  tiedhouseFederalInterest: string;
  renewalOrgLeadership: string;
  renewalkeypersonnel: string;
  renewalShareholders: string;
  renewalOutstandingFines: string;

  renewalBranding: string;
  renewalSignage: string;
  renewalEstablishmentAddress: string;
  renewalValidInterest: string;
  renewalZoning: string;
  renewalFloorPlan: string;
  renewalSiteMap: string;

  description1: string;

  isReadyValidInterest: boolean;
  isReadyWorkers: boolean;
  isReadyNameBranding: boolean;
  isReadyDisplays: boolean;
  isReadyIntruderAlarm: boolean;
  isReadyFireAlarm: boolean;
  isReadyLockedCases: boolean;
  isReadyLockedStorage: boolean;
  isReadyPerimeter: boolean;
  isReadyRetailArea: boolean;
  isReadyStorage: boolean;
  isReadyExtranceExit: boolean;
  isReadySurveillanceNotice: boolean;
  isReadyProductNotVisibleOutside: boolean;
  establishmentopeningdate: Date;
}
