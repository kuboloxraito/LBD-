import { Component, Input, OnInit } from '@angular/core';
import { Movie } from 'src/Interfaces/movie';
import { Recommendation } from 'src/Interfaces/recommendation';
import { MovieserviceService } from 'src/movieservice.service';
import { RecommendationService } from 'src/Recommendation.service';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent implements OnInit {
  @Input() movies: Array<Movie> = [];
  @Input() recommendations: Array<Recommendation> = [];
  isRecommended: Movie[]=[];
  constructor(private _service: MovieserviceService, private _recommendationService: RecommendationService) { }

  ngOnInit() {
    this.getMovies();

  }

  getMovies():void{
    this.movies=[];
    this._service.GetMovies().subscribe((resp: Movie[])=> {
    resp.forEach(movie =>(
      this.movies.push(movie)
    ));
  });
  }


}


