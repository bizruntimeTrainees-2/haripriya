import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CreatingOwnComponentComponent } from './creating-own-component.component';

describe('CreatingOwnComponentComponent', () => {
  let component: CreatingOwnComponentComponent;
  let fixture: ComponentFixture<CreatingOwnComponentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CreatingOwnComponentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CreatingOwnComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
