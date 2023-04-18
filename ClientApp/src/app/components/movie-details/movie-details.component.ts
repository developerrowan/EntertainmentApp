import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Observable, of } from 'rxjs';
import { Star } from 'src/app/interfaces/Star';
import { Movie } from 'src/app/models/Movie';
import { MovieService } from 'src/app/services/movie.service';
import { calculateStars } from 'src/app/utils/calculateStar';

@Component({
  selector: 'app-movie-details',
  templateUrl: './movie-details.component.html',
  styleUrls: ['./movie-details.component.css']
})
export class MovieDetailsComponent implements OnInit {

  protected movie: Movie | undefined = undefined;
  releaseDate = new Date();
  stars: Star[] = [];

  constructor(private movieService: MovieService, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.route.params.subscribe(params => {
      this.movieService.getMovieById(params['id']).subscribe(data => {
        this.movie = data[0];

        this.releaseDate = new Date(this.movie.releaseDate);

        this.stars = calculateStars(this.movie!.vote_average);

      });
    });
  }
}
