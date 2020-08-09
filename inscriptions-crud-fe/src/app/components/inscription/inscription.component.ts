import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ApplicantType } from 'src/app/models/applicant-type.enum';
import { Modality } from 'src/app/models/modality.enum';
import { Campus } from 'src/app/models/campus.enum';
import { Program } from 'src/app/models/program.enum';
import { AcademicPeriod } from 'src/app/models/academic-period.enum';
import { Country } from 'src/app/models/country.enum';
import { Department } from 'src/app/models/department.enum';
import { City } from 'src/app/models/city.enum';
import { BloodType } from 'src/app/models/blood-type.enum';
import { DocumentType } from 'src/app/models/document-type.enum';
import { Sex } from 'src/app/models/sex.enum';
import { CivilStatus } from 'src/app/models/civil-status.enum';
import Swal from 'sweetalert2';
import { InscriptionService } from 'src/app/services/inscription.service';
import { Inscription } from 'src/app/models/inscription';

@Component({
  selector: 'app-inscription',
  templateUrl: './inscription.component.html',
  styleUrls: ['./inscription.component.scss']
})
export class InscriptionComponent implements OnInit {
  applicantType:any[] = [];
  modalitys:any[] = [];
  campus:any[] = [];
  programs:any[] = [];
  academicPeriods:any[] = [];
  countries: any[] = [];
  departments: any[] = [];
  citys: any[] = [];
  bloodTypes: any[] = [];
  documentTypes: any[] = [];
  sexs: any[] = [];
  civilStatuss: any[] = [];
  
  
  constructor(
    private formBuilder: FormBuilder,
    private inscriptionService: InscriptionService
    ) { }

  get firstName() {
    return this.registerForm.get('firstName');
  }
  get lastName() {
    return this.registerForm.get('lastName');
  }
  get birthDate() {
    return this.registerForm.get('birthDate');
  }
  get documentNumber() {
    return this.registerForm.get('documentNumber');
  }
  get expeditionDate() {
    return this.registerForm.get('expeditionDate');
  }
  get cellphoneNumber() {
    return this.registerForm.get('cellphoneNumber');
  }
  get email() {
    return this.registerForm.get('email');
  }
  get direcction() {
    return this.registerForm.get('direcction');
  }
  
  registerForm = this.formBuilder.group({
    applicantType: [ApplicantType.Nuevo],
    modality: [Modality.Presencial],
    campus: [Campus.Medellín],
    program: [Program.Odontología],
    academicPeriod: [AcademicPeriod.Período_20202],
    firstName: ['', [Validators.required]],
    lastName: ['', Validators.required],
    birthDate: ['', Validators.required],
    birthCountry: [Country.Colombia],
    birthDepartment: [Department.Antioquia],
    birthCity: [City.Medellín],
    bloodType: [BloodType.O_positivo],
    documentType: [DocumentType.Cédula_Ciudadanía],
    documentNumber: ['', [Validators.required]],
    expeditionDate: ['', [Validators.required]],
    expeditionCountry: [Country.Colombia],
    expeditionDepartment: [Department.Antioquia],
    expeditionCity: [City.Medellín],
    sex: [Sex.Femenino],
    civilStatus: [CivilStatus.Soltero],
    telephoneNumber: ['', [Validators.required]],
    cellphoneNumber: ['', [Validators.required]],
    email: ['', [Validators.required]],
    direcction: ['', [Validators.required]],
  });
  
  onSubmit() {
    if (!this.registerForm.valid) {
      Swal.fire({
        title: 'Enviar Formulario',
        text: "Algún campo no se ha llenado correctamente",
        icon: 'warning',
      });
      return;
    }
    this.inscriptionService.CreateInscription(this.registerForm.value)
      .subscribe((response: Inscription) => {
        Swal.fire(
          'Registrado!',
          'El registro se creó correctamente.',
          'success'
        )
      console.log(response);
    });
  }
  onRefresh() {
    this.registerForm.patchValue({
      applicantType: ApplicantType.Nuevo,
      modality: Modality.Presencial,
      campus: Campus.Medellín,
      program: Program.Odontología,
      academicPeriod: Program.Odontología,
      firstName: '',
      lastName: '',
      birthDate: '',
      birthCountry: Country.Colombia,
      birthDepartment: Department.Antioquia,
      birthCity: City.Medellín,
      bloodType: BloodType.O_positivo,
      documentType: DocumentType.Cédula_Ciudadanía,
      documentNumber: '', 
      expeditionDate: '', 
      expeditionCountry: Country.Colombia,
      expeditionDepartment: Department.Antioquia,
      expeditionCity: City.Medellín,
      sex: Sex.Femenino,
      civilStatus: CivilStatus.Soltero,
      telephoneNumber: '', 
      cellphoneNumber: '', 
      email: '', 
      direcction: '' 
    });
  }

  ngOnInit(): void {
    for (let item in ApplicantType) {
      if (isNaN(Number(item))) {
        this.applicantType.push({text: item, value: ApplicantType[item]});
      }
    }
    for (let item in Modality) {
      if (isNaN(Number(item))) {
        this.modalitys.push({text: item, value: Modality[item]});
      }
    }
    for (let item in Campus) {
      if (isNaN(Number(item))) {
        this.campus.push({text: item, value: Campus[item]});
      }
    }
    for (let item in Program) {
      if (isNaN(Number(item))) {
        this.programs.push({text: item, value: Program[item]});
      }
    }
    for (let item in AcademicPeriod) {
      if (isNaN(Number(item))) {
        this.academicPeriods.push({text: item, value: AcademicPeriod[item]});
      }
    }
    for (let item in Country) {
      if (isNaN(Number(item))) {
        this.countries.push({text: item, value: Country[item]});
      }
    }
    for (let item in Department) {
      if (isNaN(Number(item))) {
        this.departments.push({text: item, value: Department[item]});
      }
    }
    for (let item in City) {
      if (isNaN(Number(item))) {
        this.citys.push({text: item, value: City[item]});
      }
    }
    for (let item in BloodType) {
      if (isNaN(Number(item))) {
        this.bloodTypes.push({text: item, value: BloodType[item]});
      }
    }
    for (let item in DocumentType) {
      if (isNaN(Number(item))) {
        this.documentTypes.push({text: item, value: DocumentType[item]});
      }
    }
    for (let item in Sex) {
      if (isNaN(Number(item))) {
        this.sexs.push({text: item, value: Sex[item]});
      }
    }
    for (let item in CivilStatus) {
      if (isNaN(Number(item))) {
        this.civilStatuss.push({text: item, value: CivilStatus[item]});
      }
    } 
  }
}
