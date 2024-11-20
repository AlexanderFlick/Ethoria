using Game.Models;

namespace Game.Services;

public interface IRecipeService
{
    void Create(Chest chest, List<Resource> resources);
}

public class RecipeService(IResourceService resourceService) : IRecipeService
{
    public void Create(Chest chest, List<Resource> resources)
    {
        foreach (var resource in resources) 
        {
            chest.Contents.Remove(resource);
        }
    }
}
