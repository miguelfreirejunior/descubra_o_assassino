using System.Threading.Tasks;
using api.Models;

namespace api.Services.Impl
{
    public class GameService : IGameService
    {
        private readonly ILocalService _localService;

        private readonly IArmaService _armaService;

        private readonly ISuspeitoService _suspeitoService;

        public GameService(ILocalService localService, IArmaService armaService, ISuspeitoService suspeitoService)
        {
            this._localService = localService;
            this._armaService = armaService;
            this._suspeitoService = suspeitoService;
        }

        public string[] Locais { get; set; }

        public string[] Armas { get; set; }

        public Task<Game> create()
        {
            return Task.FromResult(new Game {
                Armas = this._armaService.list()
            });
        }
    }
}