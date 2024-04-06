public class Hamburguesa
{
    public bool Pan { get; set; }
    public bool Carne { get; set; }
    public int Precio { get; set; }
    public List<string> Ingredientes { get; set; }

    public Hamburguesa()
    {
        Pan = true;
        Carne = true;
        Precio = 20;
        Ingredientes = new List<string>();
    }

    public void AgregarIngrediente(string ingrediente)
    {
        Ingredientes.Add(ingrediente);
        Precio += 10;
    }

    public string MostrarPrecio()
    {
        return "Total: " + Precio + " pesos";
    }

    public virtual void ElegirIngredientes(List<string> ingredientesE) // IngredientesE = Ingrefientes elegidos 
    {
        foreach (var ingrediente in ingredientesE)
        {
            AgregarIngrediente(ingrediente);
        }
    }
}




