namespace DesingPatterns.DependecyIjectionPattern;

public class DrinkWithBeer
{
    //private Beer  _beer = new Beer( "Pikantus", "Erdinger"); // pero tener esto es un poblema por que aki estamos instanciando una clase que posiblemente 
    // cambie  por lo cual es mejor mandarlo como parametro en su creacion 
    // Lo correcto seria lo siguiente
    private  Beer _beer; 
     
    private decimal _water;
    private decimal _sugar; 
    
    public DrinkWithBeer(decimal water, decimal sugar, Beer beer ) //aki hicimos la inyeccion del objeto
    {
        _water = water;
        _sugar = sugar;
        _beer = beer;
    }

    public void Build()
    {
        Console.WriteLine($"Drink with {_beer.Name} , water: {_water} and sugar: {_sugar}");
    }
}