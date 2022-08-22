import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

import { PersonService } from "../person.service"

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent implements OnInit {
  createForm;
 
  constructor(public personService: PersonService,
    private route: ActivatedRoute,
    private router: Router,
    private formBuilder: FormBuilder
  ) {
    this.createForm = this.formBuilder.group({
      shirtNo: ['', Validators.required],
      name: ['', Validators.required],
      goals: [''],
    });

  }

  ngOnInit(): void {
    

  }
  onSubmit(formData: { value: object; }) {
    this.personService.createPerson(formData.value).subscribe(res => {
      this.router.navigateByUrl('person/list');
    })
  }

}
