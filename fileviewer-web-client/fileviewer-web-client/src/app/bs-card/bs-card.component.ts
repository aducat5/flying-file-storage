import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-bs-card',
  templateUrl: './bs-card.component.html',
  styleUrls: ['./bs-card.component.css'],
})
export class BsCardComponent implements OnInit {
  @Input() cardTitle = '';
  
  constructor() { }

  ngOnInit(): void {
  }

}
