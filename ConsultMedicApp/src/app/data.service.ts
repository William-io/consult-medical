import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  public baseUrl = "https://localhost:5001";

  constructor(
    private http: HttpClient
  ) { }

  //Receber o token do usuário, 
  public composeHeaders(token) {
    if (token) {
      const headers = new HttpHeaders().set('Authorization', `Bearer ${token}`);
      return headers;
    } else {
      return null;
    }
  }
  public getTodayConsults(token) {
    return this.http.get(`${this.baseUrl}/v1/consults/undone/today`, { headers: this.composeHeaders(token) });
  }
  public getTomorrowConsults(token) {
    return this.http.get(`${this.baseUrl}/v1/consults/undone/tomorrow`, { headers: this.composeHeaders(token) });
  }

  public getAllConsults(token) {
    return this.http.get(`${this.baseUrl}/v1/consults`, { headers: this.composeHeaders(token) });
  }

  public postConsults(data, token) {
    return this.http.post(`${this.baseUrl}/v1/consults`, data, { headers: this.composeHeaders(token) });
  }

  public markAsDone(data, token) {
    return this.http.put(`${this.baseUrl}/v1/consults/mark-as-done`, data, { headers: this.composeHeaders(token) });
  }

}
