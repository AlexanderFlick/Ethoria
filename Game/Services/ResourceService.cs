﻿using Game.Models;

namespace Game.Services;

public interface IResourceService
{
    void AddToChest(Chest chest, Resource resource);
}

public class ResourceService : IResourceService
{
    public void AddToChest(Chest chest, Resource resource)
    {
        if (chest.Contents.Count == chest.ItemMax)
            return;

        chest.Contents.Add(resource);
    }
}
