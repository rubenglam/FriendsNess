import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AuthService } from '../auth/services/auth.service';
import { HomeIndexPageComponent } from './pages/home-index-page/home-index-page.component';
import { HomeAuthorizedComponent } from './components/home-authorized/home-authorized.component';
import { HomeUnauthorizedComponent } from './components/home-unauthorized/home-unauthorized.component';
import { MyExercicesComponent } from './components/my-exercices/my-exercices.component';
import { LoadingComponent } from '../../shared/loading/loading.component';
import { SharedModule } from '../../shared/shared.module';

@NgModule({
  declarations: [
    HomeIndexPageComponent,
    HomeAuthorizedComponent,
    HomeUnauthorizedComponent,
    MyExercicesComponent,
  ],
  exports: [HomeIndexPageComponent],
  imports: [CommonModule, SharedModule],
})
export class HomeModule {}
