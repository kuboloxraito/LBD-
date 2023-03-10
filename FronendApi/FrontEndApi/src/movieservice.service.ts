import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Movie } from './Interfaces/movie';

@Injectable({
  providedIn: 'root'
})
export class MovieserviceService {


  private BaseUrl:string="https://localhost:7071/api";
  private GetMoviesByTitleURL:string="https://localhost:7071/api/Movie/GetMoviesByTitle?keyWord=";
  private DetailsUrl:string ="https://localhost:7071/api/Movie/movie?id=";
constructor(private http: HttpClient) { }

GetMovies(){
  let enterUrl= 'https://localhost:7071/api/Movie/popular?page=1'
  return this.http.get<Array<Movie>>(enterUrl);
}

GetMoviesByTitle(title:string): Observable<Array<Movie>>
{
  return this.http.get<Array<Movie>>(this.GetMoviesByTitleURL + title);
}

GetDetails(id: number) {
  return this.http.get<Movie>(this.DetailsUrl + id);
}

}
