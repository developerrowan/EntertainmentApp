import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { HomeComponent } from './components/home/home.component';
import { MoviesListComponent } from './components/movies-list/movies-list.component';
import { MovieDetailsComponent } from './components/movie-details/movie-details.component';
import { TvShowsListComponent } from './components/tv-shows-list/tv-shows-list.component';
import { TvShowDetailsComponent } from './components/tv-show-details/tv-show-details.component';
import { TvShowService } from './services/tv-show.service';
import { MovieService } from './services/movie.service';
import { TvCardComponent } from './components/tv-card/tv-card.component';
import { MovieCardComponent } from './components/movie-card/movie-card.component';
import { NgxPaginationModule } from 'ngx-pagination';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    MovieCardComponent,
    MoviesListComponent,
    MovieDetailsComponent,
    TvCardComponent,
    TvShowsListComponent,
    TvShowDetailsComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    NgxPaginationModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'movies', component: MoviesListComponent },
      { path: 'movies/:id', component: MovieDetailsComponent },
      { path: 'shows', component: TvShowsListComponent },
      { path: 'shows/:id', component: TvShowDetailsComponent },
    ])
  ],
  providers: [TvShowService, MovieService],
  bootstrap: [AppComponent]
})
export class AppModule { }
