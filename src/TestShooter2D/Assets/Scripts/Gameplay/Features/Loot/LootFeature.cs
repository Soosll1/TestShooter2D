using Gameplay.Features.Loot.Systems;
using Infrastructure.Systems;

namespace Gameplay.Features.Loot
{
    public class LootFeature : Feature
    {
        public LootFeature(ISystemsFactory systems)
        {
            Add(systems.Create<DropLootFromEnemiesFeature>());
            
            Add(systems.Create<CastForCollectableSystem>());
            Add(systems.Create<SetDirectionForCollectingSystem>());
            Add(systems.Create<CollectingSystem>());
            Add(systems.Create<CollectWhenNearSystem>());
            Add(systems.Create<ApplyCollectedAmmoSystem>());
            
            Add(systems.Create<ClearCollectedSystem>());
        }
    }
}