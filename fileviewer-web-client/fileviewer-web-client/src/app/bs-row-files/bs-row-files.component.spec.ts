import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BsRowFilesComponent } from './bs-row-files.component';

describe('BsRowFilesComponent', () => {
  let component: BsRowFilesComponent;
  let fixture: ComponentFixture<BsRowFilesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BsRowFilesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BsRowFilesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
