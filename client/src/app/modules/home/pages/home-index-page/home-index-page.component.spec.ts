import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HomeIndexPageComponent } from './home-index-page.component';

describe('HomeIndexPageComponent', () => {
  let component: HomeIndexPageComponent;
  let fixture: ComponentFixture<HomeIndexPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HomeIndexPageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HomeIndexPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
