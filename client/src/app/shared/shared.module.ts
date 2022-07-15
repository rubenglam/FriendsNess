import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavbarComponent } from './navbar/navbar.component';

import { NotFoundComponent } from './not-found/not-found.component';
import { RouterModule } from '@angular/router';
import { LoadingComponent } from './loading/loading.component';

@NgModule({
  declarations: [NavbarComponent, NotFoundComponent, LoadingComponent],
  exports: [NavbarComponent, NotFoundComponent, LoadingComponent],
  imports: [CommonModule, RouterModule],
})
export class SharedModule { }
