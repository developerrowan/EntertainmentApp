import { Component, Input, OnInit } from '@angular/core';
import { TvShow } from 'src/app/models/TvShow';

@Component({
  selector: 'tv-card',
  templateUrl: './tv-card.component.html',
  styleUrls: ['./tv-card.component.css']
})
export class TvCardComponent implements OnInit {

  @Input()
  show: TvShow | undefined = undefined;

  constructor() { }

  ngOnInit(): void {
  }

}
