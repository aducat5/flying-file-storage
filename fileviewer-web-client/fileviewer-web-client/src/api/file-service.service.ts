import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class FileService {

  constructor() { }

  uploadFiles = function (files : FileList){
    for (let i = 0; i < files.length; i++) {
      const file = files[i];
      console.log(file.name);
    }
  }
}
