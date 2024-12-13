using Common.Entity;
using Common.Extensions;
using Infrastructure.AssetManagement;
using Infrastructure.Identifiers;
using UnityEngine;

namespace Gameplay.Features.Loot.Factory
{
    public class LootFactory : ILootFactory
    {
        private readonly IIdentifierService _identifiers;
        private readonly IStaticDataService _staticDataService;

        public LootFactory(IIdentifierService identifiers, IStaticDataService staticDataService)
        {
            _identifiers = identifiers;
            _staticDataService = staticDataService;
        }
        
        public GameEntity CreateLoot(Vector3 at)
        {
            var config = _staticDataService.GetLootConfig();

            var value = Random.Range(config.MinValue, config.MaxValue);
            
            return CreateEntity.Empty()
                .AddId(_identifiers.Next())
                .AddWorldPosition(at)
                .AddLootValue(value)
                .AddViewPrefab(config.ViewPrefab)
                .With(x => x.isMovementAvailable = true)
                .With(x => x.isLoot = true)
                .With(x => x.isCollectable = true);
        }
    }
}