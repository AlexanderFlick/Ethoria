namespace Game.Models;

public abstract record Resource(string name, int value, string description);

public record Wood(string name = "Wood", int value = 1, string description = "A piece of wood.") : Resource(name, value, description);
public record Stone(string name = "Stone", int value = 1, string description = "A common rock.") : Resource(name, value, description);