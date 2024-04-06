public class HamburguesaClasica : Hamburguesa
{
    private int MaxIngredientes = 4;

    public HamburguesaClasica() : base()
    {
    }

    public override void ElegirIngredientes(List<string> ingredientesE)
    {
        if (ingredientesE.Count <= MaxIngredientes)
        {
            base.ElegirIngredientes(ingredientesE);
        }
        else
        {
            Console.WriteLine("No puedes elegir mas de 4 ingredientes");
        }
    }
}

