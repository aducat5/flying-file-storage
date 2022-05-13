import { Component, Input, OnInit } from '@angular/core';
import { StoredFile } from 'src/model/stored-file';

@Component({
  selector: 'app-bs-row-files',
  templateUrl: './bs-row-files.component.html',
  styleUrls: ['./bs-row-files.component.css']
})
export class BsRowFilesComponent implements OnInit {
  @Input() files = [] as StoredFile[];
  @Input() cardType = "";
    
  constructor() {}
  
  ngOnInit(): void {
  }
}
