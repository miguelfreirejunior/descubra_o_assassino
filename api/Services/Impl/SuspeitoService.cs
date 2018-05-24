using System.Threading.Tasks;
using System.Linq;
using api.Models;
using System;

namespace api.Services.Impl
{
    public class SuspeitoService : ISuspeitoService
    {
        public Task<IQueryable<Suspeito>> List()
        {
            return Task.FromResult(new Suspeito[] {
                new Suspeito(1, "Esqueleto"),
                new Suspeito(2, "Khan"),
                new Suspeito(3, "Darth vader"),
                new Suspeito(4, "Sideshow Bob"),
                new Suspeito(5, "Coringa"),
                new Suspeito(6, "Duende Verde ")
            }.AsQueryable());
        }

        public async Task<Suspeito> Random()
        {
            IQueryable<Suspeito> suspeitos = await this.List();

            int toSkip = new Random().Next(0, suspeitos.Count());
            return suspeitos.Skip(toSkip).First();
        }
    }
}