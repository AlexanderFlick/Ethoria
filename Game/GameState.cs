using Game.Models;

namespace Game;

public class GameState
{
    public Player Player { get; set; } = new Player();
    public Action OnStateChanged { get; set; }
}

public class Player
{
    public List<Area> UnlockedAreas { get; set; } = [];
    public List<Resource> UnlockedResources { get; set; } = [];
    public Chest Chest { get; set; }

    public Player()
    {
        UnlockedResources.Add(new Wood());
        UnlockedResources.Add(new Stone());
        UnlockedAreas.Add(new BeginnerIsland([new Wood()]));
        UnlockedAreas.Add(new Ethoria([new Stone()]));
        Chest = new();
    }
}

public class Chest
{
    public int ItemMax { get; set; } = 10;
    public List<Resource> Contents { get; set; } = [];
}
