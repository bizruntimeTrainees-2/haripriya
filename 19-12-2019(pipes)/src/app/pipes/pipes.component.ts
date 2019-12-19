import { SuperHeros } from './superHeros';
import { Component,OnInit} from '@angular/core';

@Component({
  selector: 'pipes',
  templateUrl: './pipes.component.html',
  styleUrls: ['./pipes.component.css']
})
export class PipesComponent implements OnInit {

  name="this is angular tutorial";
  TestDate=new Date(1982,3,18);

  SuperHeros:SuperHeros[];
  

  ngOnInit() {
    this.SuperHeros=[
    
      {Id:1,Name:"IRON Man"},
      {Id:2,Name:"THOR"},
      {Id:3,Name:"HULK"}

    ];
  }
}