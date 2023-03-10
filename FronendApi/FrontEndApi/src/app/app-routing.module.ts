import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DetailsComponent } from 'src/details/details.component';
import { MainComponent } from 'src/main/main.component';
import { NavbarComponent } from 'src/navbar/navbar.component';
import { RecommendedComponent } from 'src/recommended/recommended.component';
import { SearchComponent } from 'src/search/search.component';

const routes: Routes = [
  { path: 'main', component:MainComponent},
  { path: 'navbar', component:NavbarComponent},
  { path: 'recommended', component:RecommendedComponent},
  { path: 'searched/:text', component:SearchComponent},
  { path: 'details/:id', component:DetailsComponent},
  { path: '', redirectTo: '/main', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
