namespace Game.Models;

public abstract record Resource(string Name, int Value, string Description);

public record Wood(string Name = "Wood", int Value = 1, string Description = "A piece of wood.") : Resource(Name, Value, Description);
public record Stone(string Name = "Stone", int Value = 1, string Description = "A common rock.") : Resource(Name, Value, Description);