using api.Models;

namespace api.Services.Impl
{
    public class LocalService : ILocalService
    {
        public Local[] list()
        {
            return new Local[]{
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
            };
        }
    }
}