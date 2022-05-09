import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ExercicesIndexPageComponent } from './exercices-index-page.component';

describe('ExercicesIndexPageComponent', () => {
  let component: ExercicesIndexPageComponent;
  let fixture: ComponentFixture<ExercicesIndexPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ExercicesIndexPageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ExercicesIndexPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
