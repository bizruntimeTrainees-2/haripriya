import { take, map, combineAll } from 'rxjs/operators';
import { interval } from 'rxjs';

const source = interval(1000).pipe(take(2));
const example = source.pipe(
  map(val =>
    interval(1000).pipe(
      map(i => `Result (${val}): ${i}`),
      take(5)
    )
  )
);
example
  .pipe(combineAll())
  .subscribe(console.log);