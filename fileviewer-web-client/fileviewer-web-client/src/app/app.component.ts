import { Component } from '@angular/core';
import FileService from 'src/api/file-service.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  constructor(private fileService : FileService){}
  onFileUpload = (event : Event) => {
    const input = event.target as HTMLInputElement;
    const files = input.files as FileList;

    if (files.length > 0){
      
      for (let i = 0; i < files.length; i++) {
        const file = files[i];
        
        this.fileService.upload(file).subscribe((data : any) => {console.log(data)});
      }
      
    }else{
      console.log("error");
    }
  };

}
