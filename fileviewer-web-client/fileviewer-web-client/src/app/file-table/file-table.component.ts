import { Component, Input, OnInit } from '@angular/core';
import { StoredFile } from 'src/model/stored-file';

@Component({
  selector: 'app-file-table',
  templateUrl: './file-table.component.html',
  styleUrls: ['./file-table.component.css']
})

export class FileTableComponent implements OnInit {
  @Input() files = [] as StoredFile[];
  formatBytes = function (bytes : any, decimals = 2) {
    if (bytes === 0) return '0 Bytes';

    const k = 1024;
    const dm = decimals < 0 ? 0 : decimals;
    const sizes = ['Bytes', 'KB', 'MB', 'GB', 'TB', 'PB', 'EB', 'ZB', 'YB'];

    const i = Math.floor(Math.log(bytes) / Math.log(k));

    return parseFloat((bytes / Math.pow(k, i)).toFixed(dm)) + ' ' + sizes[i];
}
  constructor() {}
  
  
  ngOnInit(): void {
  }

}
