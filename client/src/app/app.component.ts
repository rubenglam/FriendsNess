import { Component } from '@angular/core';
import { ExercicesService } from './core/http/exercices.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'friendsness';

  constructor() {
  }
}
