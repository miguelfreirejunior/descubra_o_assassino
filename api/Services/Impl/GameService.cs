using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using api.Models;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

namespace api.Services.Impl
{
    public class GameService : IGameService
    {
        private readonly IDistributedCache _cache;

        private readonly ILocalService _localService;

        private readonly ISuspeitoService _armaService;

        private readonly ISuspeitoService _suspeitoService;

        public GameService(ILocalService localService, ISuspeitoService armaService, ISuspeitoService suspeitoService, IDistributedCache cache)
        {
            this._localService = localService;
            this._armaService = armaService;
            this._suspeitoService = suspeitoService;
            _cache = cache;
        }

        public string[] Locais { get; set; }

        public string[] Armas { get; set; }

        public async Task<string> Create()
        {
            string id = Guid.NewGuid().ToString();
            Game game = new Game
            {
                Arma = (await this._armaService.Random()).Id,
                Local = (await this._localService.Random()).Id,
                Suspeito = (await this._suspeitoService.Random()).Id
            };

            await this._cache.SetStringAsync(id, JsonConvert.SerializeObject(game));
            return id;
        }

        public async Task<short> Guess(Guess guess)
        {
            string gameString = await this._cache.GetStringAsync(guess.Id);
            Game game = JsonConvert.DeserializeObject<Game>(gameString);

            List<short> falhas = new List<short>();
            if(!guess.Suspeito.Equals(game.Suspeito)){
                falhas.Add(1);
            }

            if(!guess.Local.Equals(game.Local)){
                falhas.Add(2);
            }

            if(!guess.Arma.Equals(game.Arma)){
                falhas.Add(3);
            }

            if(falhas.Count <= 0){
                return 0;
            }else{
                int toSkip = new Random().Next(0, falhas.Count);
                return falhas[toSkip];
            }
        }
    }
}