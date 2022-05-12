import { Component } from '@angular/core';
import { FileService } from 'src/api/file-service.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  onFileUpload = (event : Event) => {
    const input = event.target as HTMLInputElement;
    const files = input.files as FileList;
    if (files.length > 0){
      const fileService = new FileService();
      fileService.uploadFiles(files);
    }else{
      console.log("error");
    }
  };

}
