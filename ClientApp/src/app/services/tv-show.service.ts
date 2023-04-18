import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { TvShow } from '../models/TvShow';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TvShowService {

  private apiUrl: string = 'https://localhost:44490/entertainment/tvshows';

  constructor(private http: HttpClient) { }

  public getAllShows(): Observable<TvShow[]> {
    return this.http.get<TvShow[]>(`${this.apiUrl}/`);
  }

  public getShowById(id: number): Observable<TvShow[]> {
    return this.http.get<TvShow[]>(`${this.apiUrl}/${id}`);
  }

  public getMostPopularShows(): Observable<TvShow[]> {
    return this.http.get<TvShow[]>(`${this.apiUrl}/popular`);
  }

  public getTopRatedShows(): Observable<TvShow[]> {
    return this.http.get<TvShow[]>(`${this.apiUrl}/top-rated`);
  }
}
