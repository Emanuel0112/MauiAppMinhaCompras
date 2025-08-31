using SQLite;

namespace MauiAppMinhaCompras.Models
{
    public class Produto
    {
        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }

        public string Descricao { get; set; } = string.Empty;

        public double Quantidade { get; set; }

        public double Preco { get; set; }

        public double Total { get => Quantidade * Preco; }
    }
}
