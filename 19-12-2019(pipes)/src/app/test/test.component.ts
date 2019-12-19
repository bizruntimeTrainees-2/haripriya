import { Component, OnInit } from '@angular/core';

@Component({
  //selector: '.app-test',
  selector: '[app-test]',
 // templateUrl: './test.component.html',
  template:`
            <div>
            INLINE TEMPLATE
            <h2>Welcome {{2+3}}{{name}}</h2>
            <h2>{{"Welcome "+name}}</h2>
            <h2>{{name.length}}</h2>
            <h2>{{name.toUpperCase()}}</h2> 
            <h2>{{greetUser()}}</h2>
            <h2>{{siteUrl}}</h2>
            <input [id]="myId" type="text" value="ABC">
            <input [disabled]="isDiabled" id="{{myId}}" type="text" value="ABC">
            <input bind-disabled="isDiabled" id="{{myId}}" type="text" value="ABC">
           
           
            <h2>
            welcome {{name}}
            </h2>
            <h2 class="text-success">ANGULAR</h2>
            <h2 [class]="successClass">ANGULAR</h2>
            <h2 [class.text-danger]="hasError">ANGULARDEVELOPMENT</h2>
            <h2 [ngClass]="messageClasses">ANGULAR</h2> 
            
            
            <button (click)="onclick($event)">GREAT</button>
            <button (click)="greeting='welcome ABC'">Greet</button>
            {{greeting}}
            <input #myInput type="text">
            <button (click)="logmessage(myInput.value)">LOG</button>  
            <button (click)="logmessage(myInput.value)">LOG</button>
            
            <input [(ngModel)]="name1" type="text">
            {{name1}}
            <h2 *ngIf="true">
             angular
            </h2> 
            
            </div>
            `,
  //styleUrls: ['./test.component.css']
  //<h2>{{a=2+2}}</h2>(we can't assign)


  styles:[`
    div{
      color:red;
    }
    .text-success{
      color:green;
    }
    .text-danger{
      color:red;
    }
    .text-special{
      font-style:italic;
    }
  `]
})
  export class TestComponent implements OnInit {

  public name="star";
  public siteUrl=window.location.href;
  public myId="testId";//value to html
  public isDisabled=false;


  public successClass="text-success";
  public hasError=true;
  public isSpecial=true;
  public messageClasses={
    "text-success":!this.hasError,
    "text-danger":this.hasError,
    "text-special":this.isSpecial
  }

  public greeting="";
  
  displayName= true; 

  public name1="";

  onclick(event){
    console.log(event);
    //this.greeting='welcome to angular';
    this.greeting=event.type;

  }




  constructor() { }
  ngOnInit() {
  }

  greetUser(){
    return "Hello "+this.name;
  }



  logmessage(value)  
   {
     console.log(value);
   }

}