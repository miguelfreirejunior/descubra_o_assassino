import { Component, OnInit } from '@angular/core';
import { GameService } from '../game.service';
import { Resource } from '../resource';
import { Observable } from 'rxjs';
import { Guess } from '../guess';
import {MatSnackBar} from '@angular/material';

@Component({
  selector: 'app-game',
  templateUrl: './game.component.html',
  styleUrls: ['./game.component.css']
})
export class GameComponent implements OnInit {

  game: string;
  sucesso: boolean = false;
  armas: Observable<Resource>;
  suspeitos: Observable<Resource>;
  locais: Observable<Resource>;
  texto: string;
  guess: Guess;

  falaDaTestemunha: string;

  constructor(private gameService: GameService, public snackBar: MatSnackBar) { }

  ngOnInit() {
    this.armas = this.gameService.armas();
    this.suspeitos = this.gameService.suspeitos();
    this.locais = this.gameService.locais();
  }

  start(): void {
    this.texto = `O empresário Sean Bean foi assassinado e o corpo dele foi deixado na frente da delegacia de polícia. O Inspetor Jacques
    Clouseau foi escolhido para investigar este caso. Após uma série de investigações, ele organizou uma lista com
    prováveis assassinos, os locais do crime e quais armas poderiam ter sido utilizadas.
     Auxilie o Inspetor na interrogação da vítima através de palpites!`;

     this.guess = { arma: 1, local: 1, suspeito: 1 };
    this.falaDaTestemunha = "";
    this.sucesso = false;
    this.gameService.new().subscribe(id => this.game = id);
  }

  perguntar(): void {
    this.gameService.perguntar(this.game, this.guess)
      .subscribe(resposta => {
        switch (resposta) {
          case 1:
            this.falaDaTestemunha = "O assassino não foi este que você me falou";
            break;
          case 2:
            this.falaDaTestemunha = "O assassinato não ocorreu neste local aí";
            break;
          case 3:
            this.falaDaTestemunha = "O assassino não estava usando esta arma";
            break;
    
          default:
            this.sucesso = true;
            break;
        }
      });
  }

  private tratarResposta(resposta: number) {
    
  }
}
