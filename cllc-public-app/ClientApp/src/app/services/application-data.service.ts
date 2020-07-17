import { Injectable } from '@angular/core';
import { FileSystemItem } from '@models/file-system-item.model';
import { Application } from '@models/application.model';
import { ApplicationSummary } from '@models/application-summary.model';
import { catchError } from 'rxjs/operators';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { DataService } from './data.service';
import { CovidApplication } from '@models/covid-application.model';
import { OngoingLicenseeData } from '../models/ongoing-licensee-data';

@Injectable()
export class ApplicationDataService extends DataService {

  apiPath = 'api/applications/';

  public files: FileSystemItem[] = [];

  constructor(private http: HttpClient) {
    super();
   }

  /**
   * Get all Dynamics Applications for the current user
   * */
  getAdoxioApplications(): Observable<Application[]> {
    return this.http.get<Application[]>(this.apiPath + 'current', { headers: this.headers })
      .pipe(catchError(this.handleError));
  }
  /**
   * Get all  Applications for the current user for the given application type
   * */
  getApplicationsByType(applicationType: string): Observable<Application[]> {
    return this.http.get<Application[]>(`${this.apiPath}current/by-type/${encodeURIComponent(applicationType)}`, { headers: this.headers })
      .pipe(catchError(this.handleError));
  }

  /**
   * Gets the number of submitted Applications for the current user
   * */
  getSubmittedApplicationCount(): Observable<number> {
    return this.http.get<number>(this.apiPath + 'current/submitted-count', { headers: this.headers })
      .pipe(catchError(this.handleError));
  }

  getAllCurrentApplications(): Observable<ApplicationSummary[]> {
    return this.http.get<ApplicationSummary[]>(this.apiPath + 'current', { headers: this.headers })
      .pipe(catchError(this.handleError));
  }

  getLGApprovalApplications(): Observable<Application[]> {
    return this.http.get<Application[]>(this.apiPath + 'current/lg-approvals', { headers: this.headers })
      .pipe(catchError(this.handleError));
  }

  getOngoingLicenseeChangeApplicationId(): Observable<string> {
    return this.http.get<string>(this.apiPath + 'ongoing-licensee-application-id', { headers: this.headers })
      .pipe(catchError(this.handleError));
  }

  getOngoingLicenseeData(): Observable<OngoingLicenseeData> {
    return this.http.get<OngoingLicenseeData>(this.apiPath + 'ongoing-licensee-data', { headers: this.headers })
      .pipe(catchError(this.handleError));
  }



  /**
   * Get a Dynamics Application by application ID
   * @param applicationId
   */
  getApplicationById(applicationId: string): Observable<Application> {
    return this.http.get<Application>(this.apiPath + applicationId, { headers: this.headers })
      .pipe(catchError(this.handleError));
  }


  /**
   * Cancel the Dynamics Application
   * @param id
   */
  cancelApplication(id: string) {
    // call API
    return this.http.post(this.apiPath + id + '/cancel', { headers: this.headers })
      .pipe(catchError(this.handleError));
  }

  /**
   * Delete the Dynamics Application
   * @param id
   */
  deleteApplication(id: string) {
    // call API
    return this.http.post(this.apiPath + id + '/delete', { headers: this.headers })
      .pipe(catchError(this.handleError));
  }


  /**
   * Update the Dynamics Application
   * @param applicationData
   */
  updateApplication(applicationData: Application): Observable<Application> {
    // call API
    // console.log("===== AdoxioApplicationDataService.updateApplication: ", applicationData);
    return this.http.put<Application>(this.apiPath + applicationData.id, applicationData, { headers: this.headers })
      .pipe(catchError(this.handleError));
  }

  /**
   * Create a Dynamics Application
   * @param applicationData
   */
  createApplication(applicationData: Application): Observable<Application> {
    // call API
    // console.log("===== AdoxioApplicationDataService.createApplication: ", applicationData);
    return this.http.post<Application>(this.apiPath, applicationData, { headers: this.headers });
  }

  /**
   * Create a Dynamics Application For Covid
   * @param applicationData
   */
  createCovidApplication(applicationData: CovidApplication): Observable<CovidApplication> {
    // call API
    return this.http.post<CovidApplication>(this.apiPath + 'covid', applicationData, { headers: this.headers });
  }


  /**
   * Get a file list of documents attached to the application by ID and document type
   * @param applicationId
   * @param documentType
   */
  getFileListAttachedToApplication(applicationId: string, documentType: string): Observable<FileSystemItem[]> {
    const headers = new HttpHeaders({});
    const attachmentURL = 'api/adoxioapplication/' + applicationId + '/attachments';
    const getFileURL = attachmentURL + '/' + documentType;
    return this.http.get<FileSystemItem[]>(getFileURL, { headers: headers });
  }

  downloadFile(serverRelativeUrl: string, applicationId: string) {
    const headers = new HttpHeaders({});
    const attachmentURL = `api/file/${applicationId}/download-file/application?serverRelativeUrl=${encodeURIComponent(serverRelativeUrl)}`;
    return this.http.get(attachmentURL, { headers: headers, responseType: 'blob' })
      .pipe(catchError(this.handleError));

  }


}
