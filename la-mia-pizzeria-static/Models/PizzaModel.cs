namespace la_mia_pizzeria_static.Models
{
    public class PizzaModel
    {
        public string? Nome { get; set; }

        public string? Descrizione { get; set; }

        public int Price { get; set; }
        public PizzaModel(string? nome, string? descrizione, int price)
        {
            Nome = nome;
            Descrizione = descrizione;
            Price = price;
        }
    }
}
