import { Component } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Movie } from 'src/app/models/Movie';
import { TvShow } from 'src/app/models/TvShow';
import { MovieService } from 'src/app/services/movie.service';
import { TvShowService } from 'src/app/services/tv-show.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

  protected popularMovies: Observable<Movie[]> = of([]);
  protected popularTV: Observable<TvShow[]> = of([]);

  protected topRatedMovies: Observable<Movie[]> = of([]);
  protected topRatedTV: Observable<TvShow[]> = of([]);

  constructor(protected movieService: MovieService, protected tvService: TvShowService) { }

  ngOnInit(): void {
    this.movieService.getMostPopularMovies().subscribe((data: Movie[]) => {
      this.popularMovies = of(data);
    });

    this.movieService.getTopRatedMovies().subscribe((data: Movie[]) => {
      this.topRatedMovies = of(data);
    });

    this.tvService.getTopRatedShows().subscribe((data: TvShow[]) => {
      this.topRatedTV = of(data);
    });

    this.tvService.getMostPopularShows().subscribe((data: TvShow[]) => {
      this.popularTV = of(data);
    });
  }
}
