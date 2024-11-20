using Game.Models;

namespace Game.Services;

public interface IResourceService
{
    void AddToChest(Chest chest, Resource resource);
    void RemoveResourcesFromChest(Chest chest, List<Resource> resourcesToRemove);
}

public class ResourceService : IResourceService
{
    public void AddToChest(Chest chest, Resource resource)
    {
        if (chest.Contents.Count == chest.ItemMax)
            return;

        chest.Contents.Add(resource);
    }

    public void RemoveResourcesFromChest(Chest chest, List<Resource> resourcesToRemove)
    {
        foreach (var resource in resourcesToRemove) 
        {
            chest.Contents.Remove(resource);
        }
    }
}
