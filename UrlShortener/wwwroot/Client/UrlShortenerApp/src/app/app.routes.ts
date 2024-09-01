import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { InfoComponent } from './info.component';

export const routes: Routes = [
  { path: 'info/:id', component: InfoComponent },
];

