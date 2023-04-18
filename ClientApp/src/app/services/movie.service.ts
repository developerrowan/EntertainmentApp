import { Injectable } from '@angular/core';
import { Movie } from '../models/Movie';
import { HttpClient } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MovieService {

  private apiUrl: string = 'https://localhost:44490/entertainment/movies';

  constructor(private http: HttpClient) { }

  public getAllMovies(): Observable<Movie[]> {
    return this.http.get<Movie[]>(`${this.apiUrl}/`);
  }

  public getMovieById(id: number): Observable<Movie[]> {
    return this.http.get<Movie[]>(`${this.apiUrl}/${id}`);
  }

  public getMostPopularMovies(): Observable<Movie[]> {
    return this.http.get<Movie[]>(`${this.apiUrl}/popular`);
  }

  public getTopRatedMovies(): Observable<Movie[]> {
    return this.http.get<Movie[]>(`${this.apiUrl}/top-rated`);
  }
}
