import { Injectable } from '@angular/core';
import { Game } from './game';
import { v4 as uuid } from 'uuid';

@Injectable({
  providedIn: 'root'
})
export class GameService {

  constructor() { }

  new() : Game {
    return <Game>{
      id: uuid(),
      armas: ['faca', 'revolver'],
      locais: ['hospital', 'parque'],
      suspeitos: ['jose', 'rafael']
    };
  }
}
