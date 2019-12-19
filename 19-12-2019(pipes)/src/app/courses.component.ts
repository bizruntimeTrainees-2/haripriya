import { CoursesService } from './Courses.service';
import {Component} from '@angular/core';


@Component({
    selector:'courses',
    template:`<h2>{{"Title:"+title}}</h2>
            <ul>
                <li *ngFor="let course of courses">
                {{ course }}
                </li>
            </ul>  
     `
    //html markup
    //{{rending dyn(exe -at runtime)}}
})
// (selector)<courses> "courses"
//ref an element <div class="courses"> ".courses"
//ref an element on id:<div id="courses"> "#courses"
export class CoursesComponent{
    title="List of courses";
    courses; 
    constructor(service:CoursesService){//angular create instance over component
        //create CoursesService instance,passed to constructor
        //Dep Inje:provding depandancy of cls to constctor 
        //CoursesService-parameter in constructor OR dependency of class
        this.courses=service.getCourses();
    }
}
/*
1)template:<h2>{{"Title:"+title}}</h2>


IN EXPORT CLASS:
2)title="List of courses";-in export class
   <h2>{{ getTitle() }}</h2>
    getTitle(){
        return this.title;
    }
3)
constructor(){
        let service=new CoursesService();//init obj,we can't change at runtime
        this.courses=service.getCourses();
} //If we want pass parameter,lot of change we need to do 
//above code angular going to do this work
//ng g s email



NOTE:    
 ` break the template in multiple lines
4)DIRECTIVES to manipulate the 
5)directive that modify stucture of DOM by adding or removing

WHAT IS NGFOR:
1)NgFor is a built-in template directive that makes it easy to iterate 
over something like an array or an object and create a template for each item.
let user creates a local variable that will be available in the template


*/