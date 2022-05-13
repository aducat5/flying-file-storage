import { Component, OnInit, Input } from '@angular/core';
import { StoredFile } from 'src/model/stored-file';

@Component({
  selector: 'app-grouped-list',
  templateUrl: './grouped-list.component.html',
  styleUrls: ['./grouped-list.component.css']
})
export class GroupedListComponent implements OnInit {
  @Input() fileGroup = [] as Array<Array<StoredFile>>;
  constructor() { }

  ngOnInit(): void {
  }

}
