/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { ApiHelperService } from './api-helper.service';

describe('Service: BaseApiService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ApiHelperService]
    });
  });

  it('should ...', inject([ApiHelperService], (service: ApiHelperService) => {
    expect(service).toBeTruthy();
  }));
});
