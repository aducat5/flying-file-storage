import { Component, Input, OnInit } from '@angular/core';
import { StoredFile } from 'src/model/stored-file';

@Component({
  selector: 'app-file-table',
  templateUrl: './file-table.component.html',
  styleUrls: ['./file-table.component.css']
})
export class FileTableComponent implements OnInit {
  @Input() files = [] as StoredFile[];
  constructor() {
    
  }

  ngOnInit(): void {
  }

}
