import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ThemeService {
  private readonly THEME_KEY: string = "theme";

  public readonly THEME_LIGHT: string = "light";
  public readonly THEME_NIGHT: string = "night";

  toggleTheme() {
    const theme = this.getTheme();
    if (theme !== null) {
      const newTheme = theme === this.THEME_LIGHT ? this.THEME_NIGHT : this.THEME_LIGHT;
      this.setTheme(newTheme);
    }
  }

  setTheme(theme: string) {
    if (theme === this.THEME_NIGHT) {
      document.documentElement.classList.remove(this.THEME_LIGHT);
      document.documentElement.classList.add("dark");
      document.documentElement.setAttribute("data-theme", this.THEME_NIGHT);
      localStorage.setItem(this.THEME_KEY, this.THEME_NIGHT);
    }
    else {
      document.documentElement.classList.remove("dark");
      document.documentElement.classList.add(this.THEME_LIGHT);
      document.documentElement.setAttribute("data-theme", "light");
      localStorage.setItem(this.THEME_KEY, this.THEME_LIGHT);
    }
  }

  getTheme() {
    return localStorage.getItem(this.THEME_KEY);
  }
}
