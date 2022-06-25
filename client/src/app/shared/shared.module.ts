import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavbarComponent } from './navbar/navbar.component';

import { NotFoundComponent } from './not-found/not-found.component';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [NavbarComponent, NotFoundComponent],
  exports: [NavbarComponent, NotFoundComponent],
  imports: [CommonModule, RouterModule],
})
export class SharedModule {}
