using Common.Extensions;
using Gameplay.Features.Armament;
using Gameplay.Features.DamageApplication;
using Gameplay.Features.Death;
using Gameplay.Features.Destructed;
using Gameplay.Features.Enemy;
using Gameplay.Features.Hero;
using Gameplay.Features.Loot;
using Gameplay.Features.Movement;
using Gameplay.Features.TargetCollection;
using Gameplay.Features.UI;
using Gameplay.Input;
using Infrastructure.Systems;
using Infrastructure.View;

namespace Gameplay
{
    public class BattleFeature : Feature
    {
        public BattleFeature(ISystemsFactory systems)
        {
            Add(systems.Create<BindViewFeature>());

            Add(systems.Create<InputFeature>());
            Add(systems.Create<HeroFeature>());
            Add(systems.Create<EnemyFeature>());
            Add(systems.Create<MovementFeature>());
            Add(systems.Create<TargetCollectionFeature>());
            
            Add(systems.Create<DamageApplicationFeature>());
            Add(systems.Create<ArmamentFeature>());

            Add(systems.Create<DeathFeature>());
            Add(systems.Create<LootFeature>());
            Add(systems.Create<DestructedFeature>());
            Add(systems.Create<UIFeature>());
        }
        
    }
}