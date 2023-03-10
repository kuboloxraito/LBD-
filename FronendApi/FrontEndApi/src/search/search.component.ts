import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs/internal/Observable';
import { Movie } from 'src/Interfaces/movie';
import { MovieserviceService } from 'src/movieservice.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {
  searchMovies: Array<Movie>=[];
  search:string="";

  constructor(private service: MovieserviceService, private route: ActivatedRoute) {
    this.route.params.subscribe(param=>{
      if(param['text']){
        this.search = param['text'];

      }
    })
   }

  ngOnInit() {
    this.getMoviesByTitle();
  }

  getMoviesByTitle(){
      this.service.GetMoviesByTitle(this.search).subscribe((resp: Array<Movie>)=>{
      this.searchMovies=resp;

  });
  }
}
