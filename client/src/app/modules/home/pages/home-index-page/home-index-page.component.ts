import { Component, OnInit } from '@angular/core';
import { AuthService } from '../../../auth/services/auth.service';

@Component({
  selector: 'app-home-index-page',
  templateUrl: './home-index-page.component.html',
  styleUrls: ['./home-index-page.component.css']
})
export class HomeIndexPageComponent implements OnInit {
  userEmail: string;

  constructor(private authService: AuthService) { }

  ngOnInit(): void {
    if (this.authService.userEmail !== undefined) {
      this.userEmail = this.authService.userEmail;
    }
  }
}
