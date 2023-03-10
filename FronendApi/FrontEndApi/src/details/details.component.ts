import { Component, OnInit } from '@angular/core';
import { MovieserviceService } from 'src/movieservice.service';
import { Movie } from 'src/Interfaces/movie';
import { ActivatedRoute, Params } from '@angular/router';
import { Location } from '@angular/common';
@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent implements OnInit {
  movieId: any;
  details:any={};
  selectedMovie!: Movie;
  isReady=false;
  constructor(private _moviesService: MovieserviceService, private route: ActivatedRoute,
    private location:Location) { }

  ngOnInit() {

    this.route.params.subscribe(resp=>{

      this._moviesService.GetDetails(resp['id']).subscribe(movie=>{
        this.details=movie;

        this.isReady=true;
      })

    })

   }

  // private getRouteParams():void {
  //   this.route.params.subscribe((params:Params)=>{
  //     this.movieId= params['id'];
  //   })
  // }
  getDetails(id: number) {
    this._moviesService.GetDetails(id)
      .subscribe(
        response => this.selectedMovie = response);

  }
  goBack() {
    this.location.back();
  }

}

