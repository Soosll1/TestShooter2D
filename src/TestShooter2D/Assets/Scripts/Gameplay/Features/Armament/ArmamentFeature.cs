using Gameplay.Features.Armament.Systems;
using Infrastructure.Systems;

namespace Gameplay.Features.Armament
{
    public class ArmamentFeature : Feature
    {
        public ArmamentFeature(ISystemsFactory systems)
        {
            Add(systems.Create<MarkDestructedArmamentAfterHitSystem>());
        }
    }
}