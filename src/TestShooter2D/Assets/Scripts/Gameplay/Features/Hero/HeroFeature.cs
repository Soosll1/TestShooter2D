using Gameplay.Features.Hero.Systems;
using Infrastructure.Systems;

namespace Gameplay.Features.Hero
{
    public class HeroFeature : Feature
    {
        public HeroFeature(ISystemsFactory systems)
        {
            Add(systems.Create<SetHeroDirectionSystem>());
            Add(systems.Create<TickTimeBetweenShootsSystem>());
            Add(systems.Create<MarkHeroShootingSystem>());
            Add(systems.Create<StopHeroWhileShootingSystem>());
            Add(systems.Create<HeroShootSystem>());
            
            Add(systems.Create<HeroStartMoveReactSystem>());
            Add(systems.Create<HeroEndMoveReactSystem>());
            
            Add(systems.Create<CheckHeroAmmoSystem>());

            Add(systems.Create<HeroDeathSystem>());
            Add(systems.Create<FinalizeHeroDeathSystem>());
            Add(systems.Create<CheckHeroNoAmmoReactSystem>());
            Add(systems.Create<HeroDeathReactSystem>());
            
            Add(systems.Create<AnimateHeroSystem>());
            Add(systems.Create<CameraFollowHeroSystem>());
        }
    }
}