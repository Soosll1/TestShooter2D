using System;
using System.Collections.Generic;
using Common.Entity;
using Common.Extensions;
using Gameplay.Features.Enemy.Configs;
using Infrastructure.AssetManagement;
using Infrastructure.Identifiers;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Gameplay.Features.Enemy.Factory
{
    public class EnemyFactory : IEnemyFactory
    {
        private const int EnemyTargetBufferSize = 4;
        
        private readonly IIdentifierService _identifiers;
        private readonly IStaticDataService _staticDataService;

        public EnemyFactory(IIdentifierService identifiers, IStaticDataService staticDataService)
        {
            _identifiers = identifiers;
            _staticDataService = staticDataService;
        }
        
        public GameEntity CreateRandomZombie(Vector3 at)
        {
            var allId = (int[])Enum.GetValues(typeof(EnemyTypeId));
            var typeId = (EnemyTypeId)allId[Random.Range(1, allId.Length)];
            var config = _staticDataService.GetEnemyConfigById(typeId);

            return CreateEntity.Empty()
                .AddId(_identifiers.Next())
                .AddWorldPosition(at)
                .AddHealth(config.Health)
                .AddHealthCurrent(config.Health)
                .AddSpeed(config.Speed)
                .AddDamage(config.Damage)
                .AddViewPrefab(config.ViewPrefab)
                .AddTargetsBuffer(new List<int>(EnemyTargetBufferSize))
                .AddLayerMask(CollisionLayer.Hero.AsMask())
                .AddCastRange(config.CastRange)
                .AddDropChance(config.DropChance)
                .AddDestructTime(config.DestructTime)
                .With(x => x.isEnemy = true)
                .With(x => x.isMovementAvailable = true)
                .With(x => x.isTurnAlongDirection = true);

        }
    }
}