import { Component } from '@angular/core';


//meta info(component decorater)
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {


  


  //title = 'ANGULAR';//property
  //courses=[];
  //viewMode='map';

  
  courses = [
      { id: 1, name:'course1 ' },
      { id: 2, name:'course2 ' },
      { id: 3, name:'course3 ' },
  ];
  onAdd()
  {
    this.courses.push({id:4,name:'course4'});
  }
  OnChange(course){
    course.name='Update';
  }
  /*OnChange(course){
    let index=this.courses.indexOf(course);
    this.courses.splice(index, 1);
  }*/

}