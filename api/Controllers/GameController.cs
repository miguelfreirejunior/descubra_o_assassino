using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using  api.Models;
using api.Services;

namespace api.Controllers
{
    /// <summary>
    /// Controlador do fluxo do jogo
    /// </summary>
    [Route("api/[controller]")]
    public class GameController : Controller
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            this._gameService = gameService;
        }


        /// <summary>
        /// Inicia um novo jogo
        /// </summary>
        /// <returns>Identificador do jogo iniciado</returns>
        [HttpPost]
        [Route("create")]
        public async Task<string> Create(){
            return await this._gameService.Create();
        }


        /// <summary>
        /// Confronta a testemunha com uma possível solução
        /// </summary>
        /// <param name="guess">Palpite informado</param>
        /// <returns>
        ///     0 - indica palpite certeiro
        ///     1 - indica que o assassino está incorreto
        ///     2 - indica que o local está incorreto
        ///     3 - indica que a arma está incorreta 
        /// </returns>
        [HttpPost]
        [Route("guess")]
        public async Task<short> Guess([FromBody] Guess guess){
            return await this._gameService.Guess(guess);
        }
    }
}
