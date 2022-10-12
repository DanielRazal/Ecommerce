import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import Site from '../models/site.model';


@Injectable({
  providedIn: 'root'
})
export class SiteService {
  private baseUrl = environment.baseUrl;
  private siteUrl = environment.siteUrl;

  constructor(private http:HttpClient) { }

  GetSites():Observable<Site[]>{
    return this.http.get<Site[]>(this.baseUrl + this.siteUrl)
  }
}
