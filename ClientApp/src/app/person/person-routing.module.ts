import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListComponent } from './list/list.component';
import { DetailsComponent } from './details/details.component';
import { CreateComponent } from './create/create.component';
import { EditComponent } from './edit/edit.component';


const routes: Routes = [
  { path: 'persons', redirectTo: 'person/list', pathMatch: 'full' },
  { path: 'person/list', component: ListComponent },
  { path: 'person/:Id/details', component: DetailsComponent },
  { path: ' person/create', component: CreateComponent },
  { path: 'person /:Id/edit', component: EditComponent }
];


@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PersonRoutingModule { }
