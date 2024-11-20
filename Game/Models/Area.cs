namespace Game.Models;

public abstract record Area(string Name, List<Resource> Resources);

public record BeginnerIsland(List<Resource> Resources, string Name = "Beginner Island")
    : Area(Name, Resources);
public record Ethoria(List<Resource> Resources, string Name = "Ethoria")
    : Area(Name, Resources);
