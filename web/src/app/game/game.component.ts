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

  texto: String;

  constructor(private gameService: GameService) { }

  ngOnInit() {
  }

  start() : void {
    this.texto = `O empresário Sean Bean foi assassinado e o corpo dele foi deixado na frente da delegacia de polícia. O Inspetor Jacques
    Clouseau foi escolhido para investigar este caso. Após uma série de investigações, ele organizou uma lista com
    prováveis assassinos, os locais do crime e quais armas poderiam ter sido utilizadas.`;
    
    this.game = this.gameService.new();
  }
}
