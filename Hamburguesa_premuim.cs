public class HamburguesaPremium : Hamburguesa
{
    public HamburguesaPremium() : base()
    {
        Ingredientes.Add("papas");
        Ingredientes.Add("Refresco");
        Precio += 20;
    }
}

