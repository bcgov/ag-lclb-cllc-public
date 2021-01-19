import { Account } from "./account.model";

export class LegalEntity {
  id: string; // guid
  name: string;
  isindividual: boolean;
  sameasapplyingperson: boolean;
  legalentitytype: string;
  otherlegalentitytype: string;
  firstname: string;
  middlename: string;
  lastname: string;
  isOfficer: boolean;
  isApplicant: boolean;
  isDirector: boolean;
  isSeniorManagement: boolean;
  isShareholder: boolean;
  isPartner: boolean;
  partnerType: string;
  isOwner: boolean;
  isKeyPersonnel: boolean;
  isTrustee: boolean;
  dateofbirth: Date;
  interestpercentage: number;
  commonvotingshares: number;
  preferredvotingshares: number;
  commonnonvotingshares: number;
  preferrednonvotingshares: number;
  account: Account;
  children: LegalEntity[];
  email: string;
  dateofappointment: Date;
  dateIssued: Date;
  securityAssessmentEmailSentOn: Date;
  accountId: string;
  shareholderAccountId: string;
  phsLink: string;
  casLink: string;
  // helper fields
  shareholderType: string;
  sendConsentRequest: boolean;
  parentLegalEntityId: string;
  position: string;
  jobTitle: string;
  percentageVotingShares: number;
  numberOfMembers: number;
  annualMembershipFee: number;
  totalShares: number;
}
