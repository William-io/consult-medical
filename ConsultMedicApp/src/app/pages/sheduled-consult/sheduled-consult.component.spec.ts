import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SheduledConsultComponent } from './sheduled-consult.component';

describe('SheduledConsultComponent', () => {
  let component: SheduledConsultComponent;
  let fixture: ComponentFixture<SheduledConsultComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SheduledConsultComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SheduledConsultComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
