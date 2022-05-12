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
  upload(file : File){
    const endpoint = uploadEnpoint;

    let fileToUpload = new StoredFile();
    fileToUpload.name = file.name;
    fileToUpload.size = file.size;
    fileToUpload.type = file.type;
    fileToUpload.data = []
    //do file reading here

    return this.http.post(endpoint, {fileToUpload}, {
      headers : {'Content-Type' : 'application/json'},
      reportProgress: true, 
      observe: 'response',
    }).pipe();
  }
}
