namespace PizzaStore.DB;
/// <summary>
/// Constructs a type Pizza.
/// </summary>
public record Pizza
{
    /// <value>Property
    /// <c>Id</c> is an unique integer Id
    /// </value>
    public int Id {get; set;}
    /// <value>Property
    /// <c>Name</c> is a string name of the pizza.
    /// </value>
    public string ? Name { get; set; }
}

/// <summary>
/// A DB Class to store and manage data in memory store
/// </summary>y
public class PizzaDB
{
    /// <summary>
    /// A list of type Pizza
    /// </summary>
    private static List<Pizza> _pizzas  = new List<Pizza>()
    {
        new Pizza{ Id=1, Name="Boscos"},
        new Pizza{ Id=2, Name="Gioninos"},
        new Pizza{ Id=3, Name="Coccia House"}
    };
}