import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { InscriptionComponent } from './components/inscription/inscription.component';
import { InscrptionsComponent } from './components/inscrptions/inscrptions.component';
import { DetailsComponent } from './components/details/details.component';
import { HomeComponent } from './components/home/home.component';


const routes: Routes = [
  {path: '', component: HomeComponent },
  {path: 'inscription', component: InscriptionComponent },
  {path: 'details', component: DetailsComponent },
  {path: 'inscriptions', component: InscrptionsComponent },
  {path: 'refreshDetails', redirectTo: '/details', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
