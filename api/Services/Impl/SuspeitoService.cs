using api.Models;

namespace api.Services.Impl
{
    public class SuspeitoService : ISuspeitoService
    {
        public Suspeito[] list()
        {
            return new Suspeito[] {
                new Suspeito(1, "Esqueleto"),
                new Suspeito(2, "Khan"),
                new Suspeito(3, "Darth vader"),
                new Suspeito(4, "Sideshow Bob"),
                new Suspeito(5, "Coringa"),
                new Suspeito(6, "Duende Verde ")
            };
        }
    }
}