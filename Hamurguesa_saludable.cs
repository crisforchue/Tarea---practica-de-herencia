public class HamburguesaSaludable : Hamburguesa
{
    private int MaxIngredientes = 6;

    public HamburguesaSaludable() : base()
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
            Console.WriteLine("No puedes elegir mas de 6 ingredientes");
        }
    }
}

