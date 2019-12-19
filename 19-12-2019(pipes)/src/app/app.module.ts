import { CustomHeroPipe } from './pipes/customheropipe';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { TestComponent } from './test/test.component';
import { CoursesComponent } from './courses.component';
import { CourseComponent } from './course/course.component';
import { CoursesService } from './Courses.service';
import { ContactFormComponent } from './contact-form/contact-form.component';
import { PipesComponent } from './pipes/pipes.component';

@NgModule({
  declarations: [
    AppComponent,
    //ContactFormComponent,
    //PipesComponent
    //TestComponent,
    //CoursesComponent,
    //CourseComponent,
    PipesComponent,
    CustomHeroPipe,
  ],
  imports: [
    BrowserModule,
    //FormsModule
  ],
  providers: [
    //CoursesService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }