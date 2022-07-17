import { Component, OnInit } from '@angular/core';
import { ThemeService } from './services/theme.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  title = 'friendsness';

  constructor(private themeService: ThemeService) {}

  ngOnInit(): void {
    let theme = this.themeService.getTheme();
    if (theme === null) {
      theme = this.themeService.THEME_LIGHT;
    }
    this.themeService.setTheme(theme);
  }
}
