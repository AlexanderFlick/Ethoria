namespace Game.Models;

public abstract record Recipe(string Name, string Description, List<Resource> Ingredients);

public record Plank(List<Resource> Ingredients, string Name = "Plank", string Description = "Stronger than a piece of wood.") : Recipe(Name, Description, Ingredients);
