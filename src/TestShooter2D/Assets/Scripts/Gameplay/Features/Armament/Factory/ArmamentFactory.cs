using System.Collections.Generic;
using Common.Entity;
using Common.Extensions;
using Infrastructure.AssetManagement;
using Infrastructure.Identifiers;
using UnityEngine;

namespace Gameplay.Features.Armament.Factory
{
    public class ArmamentFactory : IArmamentFactory
    {
        private const int TargetsBufferSize = 16;
        
        private readonly IIdentifierService _identifiers;
        private readonly IStaticDataService _staticDataService;

        public ArmamentFactory(IIdentifierService identifiers, IStaticDataService staticDataService)
        {
            _identifiers = identifiers;
            _staticDataService = staticDataService;
        }

        public GameEntity CreateProjectile(Vector3 at)
        {
            var config = _staticDataService.GetArmamentConfig();
            var setup = config.ProjectileSetup;
            
            return CreateEntity.Empty()
                .AddId(_identifiers.Next())
                .AddWorldPosition(at)
                .AddSpeed(setup.Speed)
                .AddDamage(setup.Damage)
                .AddCastRange(setup.CastRange)
                .AddSelfDestructTimer(setup.LifeTime)
                .AddTargetsBuffer(new List<int>(TargetsBufferSize))
                .AddLayerMask(CollisionLayer.Enemy.AsMask())
                .AddViewPrefab(config.ViewPrefab)
                .With(x => x.isMovementAvailable = true)
                .With(x => x.isTurnAlongDirection = true)
                .With(x => x.isArmament = true);
        }
    }
}