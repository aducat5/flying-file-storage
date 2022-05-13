import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { BsCardComponent } from './bs-card/bs-card.component';
import { BsRowFilesComponent } from './bs-row-files/bs-row-files.component';
import { HttpClientModule } from '@angular/common/http';
import { GroupedListComponent } from './grouped-list/grouped-list.component';
import { FileTableComponent } from './file-table/file-table.component';

@NgModule({
  declarations: [
    AppComponent,
    BsCardComponent,
    BsRowFilesComponent,
    GroupedListComponent,
    FileTableComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
