using Game.Models;

namespace Game.Services;

public interface IAreaService
{
    void Unlock(List<Area> unlockedAreas, List<Resource> unlockedResources, Area destination);
}
public class AreaService : IAreaService
{
    public void Unlock(List<Area> unlockedAreas, List<Resource> unlockedResources, Area destination)
    {
        if (unlockedAreas.Contains(destination))
            return;

        unlockedAreas.Add(destination);
        foreach(var resource in destination.Resources)
        {
            if(!unlockedResources.Contains(resource))
                unlockedResources.Add(resource);
        }
    }
}
