import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Star } from 'src/app/interfaces/Star';
import { TvShow } from 'src/app/models/TvShow';
import { TvShowService } from 'src/app/services/tv-show.service';
import { calculateStars } from 'src/app/utils/calculateStar';

@Component({
  selector: 'app-tv-show-details',
  templateUrl: './tv-show-details.component.html',
  styleUrls: ['./tv-show-details.component.css']
})
export class TvShowDetailsComponent implements OnInit {

  protected show: TvShow | undefined = undefined;
  airDate = new Date();
  stars: Star[] = [];

  constructor(private tvService: TvShowService, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.route.params.subscribe(params => {
      this.tvService.getShowById(params['id']).subscribe(data => {
        this.show = data[0];

        if (this.show.firstAirDate) {
          this.airDate = new Date(this.show.firstAirDate);
        }

        this.stars = calculateStars(this.show!.vote_average);

      });
    });
  }
}
