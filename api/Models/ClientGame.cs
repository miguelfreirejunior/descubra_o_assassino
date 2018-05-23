namespace api.Models
{
    public class ClientGame
    {
        public string Id { get; set; }

        public Suspeito[] Suspeitos { get; set; }

        public Local[] Locais { get; set; }

        public Arma[] Armas { get; set; }
    }
}