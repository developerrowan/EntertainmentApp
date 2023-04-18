import { Component, OnInit } from '@angular/core';
import { TvShow } from 'src/app/models/TvShow';
import { TvShowService } from 'src/app/services/tv-show.service';

@Component({
  selector: 'app-tv-shows-list',
  templateUrl: './tv-shows-list.component.html',
  styleUrls: ['./tv-shows-list.component.css']
})
export class TvShowsListComponent implements OnInit {

  protected shows: TvShow[] = [];
  page: number = 1;

  constructor(protected tvService: TvShowService) { }

  ngOnInit(): void {
    this.tvService.getAllShows().subscribe((data: TvShow[]) => {
      this.shows = data;
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
        this.shows.sort((a,b) => a.name! > b.name! ? 1 : -1);
      break;

      case "ztoa":
        this.shows.sort((a,b) => b.name! > a.name! ? 1 : -1);
      break;

      case "popularity":
        this.shows.sort((a,b) => b.popularity - a.popularity);
      break;

      case "rating":
        this.shows.sort((a,b) => b.vote_count - a.vote_count || b.vote_average - a.vote_average);
      break;
    }

    this.onPageChange(1);
  }
}
