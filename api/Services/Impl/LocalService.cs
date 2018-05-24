using System.Threading.Tasks;
using System.Linq;
using api.Models;
using System;

namespace api.Services.Impl
{
    public class LocalService : ILocalService
    {
        public Task<IQueryable<Local>> List()
        {
            return Task.FromResult(new Local[]{
                new Local(1, "Etérnia"),
                new Local(2, "Vulcano"),
                new Local(3, "Tatooine"),
                new Local(4, "Springfield"),
                new Local(5, "Gotham"),
                new Local(6, "Nova York"),
                new Local(7, "Sibéria"),
                new Local(8, "Machu Picchu"),
                new Local(9, "Show do Katinguele"),
                new Local(10, "São Paulo")
            }.AsQueryable());
        }

        public async Task<Local> Random()
        {
            IQueryable<Local> locais = await this.List();

            int toSkip = new Random().Next(0, locais.Count());
            return locais.Skip(toSkip).First();
        }
    }
}