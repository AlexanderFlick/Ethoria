namespace Game.Models;

public abstract record Area(string name, List<Resource> resources);

public record BeginnerIsland(List<Resource> resources, string name = "Beginner Island") : Area(name, resources);
public record Ethoria(List<Resource> resources, string name = "Ethoria") : Area(name, resources);
