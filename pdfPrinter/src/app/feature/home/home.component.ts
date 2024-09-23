import { Component } from '@angular/core';
import { HeaderComponent } from '../../shared/header/header.component';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [
    HeaderComponent,
    FormsModule,
    ReactiveFormsModule
  ],
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})
export class HomeComponent {
  file: File | null = null;

  constructor() { }  

  inputClick() {
    document.getElementById('fileInput')!.click();
  }

  print(){
    if(!this.file){
      return;
    }

    const formdata = new FormData();
    formdata.append('file', this.file, this.file.name);

    //!send File
  }

  changeFile(event: any){
    this.file = event.target.files[0];
    console.log(this.file!.name);
    
  }
}
