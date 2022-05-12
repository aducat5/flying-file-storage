import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { BsCardComponent } from './bs-card/bs-card.component';
import { BsTableComponent } from './bs-table/bs-table.component';
// import FileService from 'src/api/file-service.service';
import { BsRowFilesComponent } from './bs-row-files/bs-row-files.component';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    BsCardComponent,
    BsTableComponent,
    BsRowFilesComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    // FileService
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
