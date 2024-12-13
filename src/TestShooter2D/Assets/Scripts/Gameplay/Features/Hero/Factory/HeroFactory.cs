using Common.Entity;
using Common.Extensions;
using Infrastructure.AssetManagement;
using Infrastructure.Identifiers;
using UnityEngine;

namespace Gameplay.Features.Hero.Factory
{
    public class HeroFactory : IHeroFactory
    {
        private readonly IIdentifierService _identifiers;
        private readonly IStaticDataService _staticDataService;

        public HeroFactory(IIdentifierService identifiers, IStaticDataService staticDataService)
        {
            _identifiers = identifiers;
            _staticDataService = staticDataService;
        }

        public GameEntity CreateHero(Vector3 at)
        {
            var config = _staticDataService.GetHeroConfig();

            return CreateEntity.Empty()
                .AddId(_identifiers.Next())
                .AddWorldPosition(at)
                .AddViewPrefab(config.ViewPrefab)
                .AddAmmoCount(config.AmmoCount)
                .AddAmmoCurrent(config.AmmoCount)
                .AddSpeed(config.Speed)
                .AddHealth(config.Health)
                .AddHealthCurrent(config.Health)
                .AddTimeBetweenShoots(config.TimeBetweenShoots)
                .AddCollectSpeed(config.CollectSpeed)
                .AddCollectDistance(config.CollectDistance)
                .AddCollectRadius(config.CollectRadius)
                .AddDestructTime(config.DestructTime)
                .With(x => x.isHero = true)
                .With(x => x.isTurnAlongDirection = true)
                .With(x => x.isCanShoot = true)
                .With(x => x.isCollector = true)
                .With(x => x.isMoving = true)
                .With(x => x.isMovementAvailable = true);
        }
    }
}