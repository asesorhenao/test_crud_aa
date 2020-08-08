import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { InscrptionsComponent } from './components/inscrptions/inscrptions.component';
import { DetailsComponent } from './components/details/details.component';
import { HomeComponent } from './components/home/home.component';


const routes: Routes = [
  {path: '', component: HomeComponent },
  {path: 'inscriptions', component: InscrptionsComponent },
  {path: 'details', component: DetailsComponent }
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
