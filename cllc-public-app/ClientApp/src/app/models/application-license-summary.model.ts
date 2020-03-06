import { License } from './license.model';
import { ApplicationType } from './application-type.model';
import { LicenceEvent } from './licence-event.model';

export class ApplicationLicenseSummary {

  establishmentId: string;
  establishmentName: string;
  establishmentAddressStreet: string;
  establishmentAddressCity: string;
  establishmentAddressPostalCode: string;
  establishmentPhoneNumber: string;
  establishmentEmail: string;
  establishmentIsOpen: boolean;

  status: string;
  licenseId: string;
  applicationId: string;
  licenceTypeName: string;
  applicationTypeName: string;
  licenseNumber: string;
  name: string;
  jobNumber: string;
  isPaid: boolean;
  paymentreceiveddate: Date;
  createdon: Date;
  modifiedon: Date;
  applicationFormFileUrl: string;
  fileName: string;
  assignedLicense: License;
  expiryDate: Date;
  allowedActions: ApplicationType[];
  storeInspected: boolean;

  actionApplications: LicenceActionApplication[];
  events: LicenceEvent[];
  transferRequested: string;
}

export interface LicenceActionApplication {
  applicationId: string;
  applicationTypeName: string;
  isPaid: boolean;
  applicationStatus: string;
}
