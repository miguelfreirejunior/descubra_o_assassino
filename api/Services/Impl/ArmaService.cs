using api.Models;

namespace api.Services.Impl
{
    public class ArmaService : IArmaService
    {
        public Arma[] list()
        {
            return new Arma[]{
                new Arma(1, "Cajado Devastador"),
                new Arma(2, "Phaser"),
                new Arma(3, "Peixeira"),
                new Arma(4, "Trezoitão"),
                new Arma(5, "Sabre de Luz"),
                new Arma(6, "Bomba")
            };
        }
    }
}