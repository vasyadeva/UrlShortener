import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse  } from '@angular/common/http';
import { Observable, catchError, throwError } from 'rxjs';
import { UrlModel } from '../models/url.model';
import { UrlInfoModel } from '../models/urlInfo.model';
@Injectable({
  providedIn: 'root'
})
export class UrlService {
  private apiUrl = 'https://localhost:7087/api/url';

  constructor(private http: HttpClient) {}

  getAllUrls(): Observable<UrlModel[]> {
    return this.http.get<UrlModel[]>(this.apiUrl);
  }
  addUrl(url: string) {
    ;
    return this.http.post<{ url?: string; error?: string }>(this.apiUrl+'/AddUrl', { url })
      .pipe(
        catchError(this.handleError)
      );
  }
  private handleError(error: HttpErrorResponse) {
    return throwError(() => error);
  }
  deleteUrl(id: number) {
    return this.http.delete<{ error?: string }>(this.apiUrl+'/DeleteUrl/'+id)
      .pipe(
        catchError(this.handleError)
      );
  }

  getInfo(id: number): Observable<UrlInfoModel> {
    return this.http.get<UrlInfoModel>(`${this.apiUrl}/GetInfo/${id}`)
      .pipe(
        catchError(this.handleError)
      );
  }
}
