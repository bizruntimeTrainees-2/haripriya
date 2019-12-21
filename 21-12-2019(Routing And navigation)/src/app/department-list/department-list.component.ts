import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-department-list',
  template: `
    <p>
      department-list works!
    </p>
    <ul class="items">
    <li *ngFor="let department of departments" (click)="onSelect(department)">
    <span class="badge">{{department.id}}</span>{{department.name}}
    </li>
    </ul>
  `,
  styles: []
})
export class DepartmentListComponent implements OnInit {

  departments=[
  {"id":1, "name":"Angular"},
  {"id":2, "name":"Node"},
  {"id":3, "name":"MongoDB"},
  {"id":4, "name":"Ruby"},
  {"id":5, "name":"Bootstrap"}
]
constructor(private router:Router){}


  ngOnInit() {
  }
  onSelect(department){
    this.router.navigate(['/departments',department.id])
  }

}
