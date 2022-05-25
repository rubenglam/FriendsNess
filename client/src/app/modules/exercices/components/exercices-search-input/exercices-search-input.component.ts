import { Component, EventEmitter, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-exercices-search-input',
  templateUrl: './exercices-search-input.component.html',
  styleUrls: ['./exercices-search-input.component.css'],
})
export class ExercicesSearchInputComponent {
  @Output() onEnter: EventEmitter<string> = new EventEmitter();

  _value: string = '';

  search() {
    this.onEnter.emit(this._value);
  }
}
