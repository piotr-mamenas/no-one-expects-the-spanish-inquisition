import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PairingViewComponent } from './pairing-view.component';

describe('NotFoundComponent', () => {
  let component: PairingViewComponent;
  let fixture: ComponentFixture<PairingViewComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PairingViewComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PairingViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
