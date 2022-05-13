import { Component } from '@angular/core';
import FileService from 'src/api/file-service.service';
import { StoredFile } from 'src/model/stored-file';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  private _fileService : FileService;
  groupedList = [] as Array<Array<StoredFile>>;
  uploadedFiles = [] as string[];

  constructor(private fileService : FileService){
    this._fileService = fileService;
    this.getAll(this._fileService);
  }
  
  getAll = (fileService : FileService) => {
    fileService.getAll().subscribe((data : any) => {
      this.groupedList = data;
    });
  };

  onFileUpload = (event : Event) => {
    const input = event.target as HTMLInputElement;
    const files = input.files as FileList;

    if (files.length > 0){
      
      for (let i = 0; i < files.length; i++) {
        const file = files[i];
        let fileToUpload = new StoredFile(file);
        
        //do file reading here
        let reader = new FileReader();
        reader.onload = () => {
          fileToUpload.data = reader.result?.toString() || "";
          this.fileService.upload(fileToUpload).subscribe((data : any) => {
            // this.groupedList = [...this.groupedList, fileToUpload];
            this.getAll(this._fileService);
            this.uploadedFiles = [...this.uploadedFiles, fileToUpload.name];
            
          });
        };
        reader.readAsDataURL(file);
      }
      
    }else{
      console.log("error");
    }
  };

}
