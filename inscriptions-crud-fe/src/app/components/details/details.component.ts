import { Component, OnInit } from '@angular/core';
import { Inscription } from 'src/app/models/inscription';
import { InscriptionService } from 'src/app/services/inscription.service';
import Swal from 'sweetalert2';
import { Router } from '@angular/router';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.scss']
})
export class DetailsComponent implements OnInit {
  inscriptions: Inscription[];

  constructor(
    private inscriptionService: InscriptionService,
    private reute: Router
  ) { }

  ngOnInit(): void {
    this.inscriptionService
      .getInscriptions()
      .subscribe((inscriptionsFromAPI: Inscription[]) => {
        this.inscriptions = inscriptionsFromAPI;
    }, err => console.error(err));
  }

  handleDelete(id: string, index: number) {
    Swal.fire({
      title: 'Está seguro que desea eliminar?',
      text: "Luego de eliminado no se puede revertir la acción",
      icon: 'warning',
      showCancelButton: true,
      confirmButtonColor: '#3085d6',
      cancelButtonColor: '#d33',
      confirmButtonText: 'Si, eliminar'
    }).then((result) => {
      if (result.value) {
        this.inscriptionService
          .DeleteInscription(id)
          .subscribe((inscriptionFromAPI: Inscription[]) => {
          });
        Swal.fire(
          'Eliminado!',
          'El registro se eliminó correctamente.',
          'success'
        )
      }
      this.reute.navigate(['']);
    });
  }
}
