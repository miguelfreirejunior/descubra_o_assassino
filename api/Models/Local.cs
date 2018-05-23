namespace api.Models
{
    public class Local
    {
        public Local(int id, string descricao)
        {
            this.Id = id;
            this.Descricao = descricao;
        }

        public int Id { get; set; }

        public string Descricao { get; set; }
    }
}