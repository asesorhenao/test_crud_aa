import { Component, OnInit } from '@angular/core';
import { Inscription } from '../../models/inscription';
import { InscriptionService } from '../../services/inscription.service';

@Component({
  selector: 'app-inscrptions',
  templateUrl: './inscrptions.component.html',
  styleUrls: ['./inscrptions.component.scss']
})
export class InscrptionsComponent implements OnInit {

  constructor(
    private inscriptionService: InscriptionService
  ) { }

  ngOnInit(): void {
  }

  notFound = false;
  inscription: Inscription;

  getInscription(inscriptionId: string) {
    this.notFound = false;
    this.inscription = null;

    this.inscriptionService.getInscription(inscriptionId).subscribe((inscriptionFromTheAPI: Inscription) => {
      this.inscription = inscriptionFromTheAPI;
      }, (err: any) => {
      console.error(err);
      this.notFound = true;
    });
  }

}
