import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-bs-row-files',
  templateUrl: './bs-row-files.component.html',
  styleUrls: ['./bs-row-files.component.css']
})
export class BsRowFilesComponent implements OnInit {
  @Input() cardTitle = ''
  constructor() { }

  ngOnInit(): void {
  }

}
