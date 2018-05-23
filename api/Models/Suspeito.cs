namespace api.Models
{
    public class Suspeito
    {
        public Suspeito(int id, string descricao)
        {
            this.Id = id;
            this.Descricao = descricao;
        }

        public int Id { get; set; }

        public string Descricao { get; set; }
    }
}