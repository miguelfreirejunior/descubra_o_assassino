using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Services.Impl
{
    public class ArmaService : IArmaService
    {
        public Task<IQueryable<Arma>> List()
        {
            return Task.FromResult(new Arma[]{
                new Arma(1, "Cajado Devastador"),
                new Arma(2, "Phaser"),
                new Arma(3, "Peixeira"),
                new Arma(4, "Trezoitão"),
                new Arma(5, "Sabre de Luz"),
                new Arma(6, "Bomba")
            }.AsQueryable());
        }

        public async Task<Arma> Random()
        {
            IQueryable<Arma> armas = await this.List();

            int toSkip = new Random().Next(0, armas.Count());
            return armas.Skip(toSkip).First();
        }
    }
}