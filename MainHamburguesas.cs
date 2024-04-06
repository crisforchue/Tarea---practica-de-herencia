class Program
{
    static void Main(string[] args)
    {
        HamburguesaClasica hamburguesaClasica = new HamburguesaClasica();
        hamburguesaClasica.ElegirIngredientes(new List<string> { "Lechuga", "Tomate" });
        Console.WriteLine("Total Hamburguesa Clásica: " + hamburguesaClasica.MostrarPrecio());

        HamburguesaSaludable hamburguesaSaludable = new HamburguesaSaludable();
        hamburguesaSaludable.ElegirIngredientes(new List<string> { "Lechuga", "Tomate", "Cebolla" });
        Console.WriteLine("Total Hamburguesa Saludable: " + hamburguesaSaludable.MostrarPrecio());

        HamburguesaPremium hamburguesaPremium = new HamburguesaPremium();
        Console.WriteLine("Total Hamburguesa Premium: " + hamburguesaPremium.MostrarPrecio());
    }
}





