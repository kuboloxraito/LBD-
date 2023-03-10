import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from 'src/navbar/navbar.component';
import { MainComponent } from 'src/main/main.component';
import { DetailsComponent } from 'src/details/details.component';
import { FooterComponent } from 'src/footer/footer.component';
import { HttpClientModule } from '@angular/common/http';
import { RecommendedComponent } from 'src/recommended/recommended.component';
import { SearchComponent } from 'src/search/search.component';

@NgModule({
  declarations: [
    AppComponent,
      NavbarComponent,
      MainComponent,
      DetailsComponent,
      FooterComponent,
      RecommendedComponent,
      SearchComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [HttpClientModule,],
  bootstrap: [AppComponent]
})
export class AppModule { }
