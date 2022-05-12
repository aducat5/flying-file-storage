import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import {uploadEnpoint, getAllEnpoint} from './endpoints';
import { StoredFile } from 'src/model/stored-file';

@Injectable({
  providedIn: 'root'
})
export default class FileService {
  constructor(private http : HttpClient) {}
  upload(file : StoredFile){
    const endpoint = uploadEnpoint;


    return this.http.post(endpoint, file, {
      headers : {'Content-Type' : 'application/json'},
      reportProgress: true, 
      observe: 'response',
    }).pipe();
  }
}
