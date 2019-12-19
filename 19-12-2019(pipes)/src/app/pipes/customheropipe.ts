import { Pipe,PipeTransform} from '@angular/core';

@Pipe({name:'CustomHero'})
export class CustomHeroPipe implements PipeTransform{
    transform(value:string,Id:number) :string
    {
           return value + "# RANK"+Id.toString();
    }
}