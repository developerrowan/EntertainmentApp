import { Component, OnInit } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Movie } from 'src/app/models/Movie';
import { MovieService } from 'src/app/services/movie.service';

@Component({
  selector: 'app-movies-list',
  templateUrl: './movies-list.component.html',
  styleUrls: ['./movies-list.component.css']
})
export class MoviesListComponent implements OnInit {

  protected movies: Movie[] = [];
  page: number = 1;

  constructor(protected movieService: MovieService) { }

  ngOnInit(): void {
    this.movieService.getAllMovies().subscribe((data: Movie[]) => {
      this.movies = data;
      this.filter("popularity");
    });
  }

  onPageChange(page: number) {
    this.page = page;
    window.scrollTo(0, 0);
  }

  filter(sortBy: string) {
    switch (sortBy) {
      case "atoz":
        this.movies.sort((a,b) => a.title! > b.title! ? 1 : -1);
      break;

      case "ztoa":
        this.movies.sort((a,b) => b.title! > a.title! ? 1 : -1);
      break;

      case "popularity":
        this.movies.sort((a,b) => b.popularity - a.popularity);
      break;

      case "rating":
        this.movies.sort((a,b) => b.vote_count - a.vote_count || b.vote_average - a.vote_average);
      break;
    }

    this.onPageChange(1);
  }
}
