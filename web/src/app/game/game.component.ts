import { Component, OnInit } from '@angular/core';
import { GameService } from '../game.service';
import { Game } from '../game';

@Component({
  selector: 'app-game',
  templateUrl: './game.component.html',
  styleUrls: ['./game.component.css']
})
export class GameComponent implements OnInit {

  game: Game;

  constructor(private gameService: GameService) { }

  ngOnInit() {
  }

  start() : void {
    this.game = this.gameService.new();
  }
}
