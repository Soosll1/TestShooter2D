using Gameplay.Features.Death.Systems;
using Infrastructure.Systems;

namespace Gameplay.Features.Death
{
    public class DeathFeature : Feature
    {
        public DeathFeature(ISystemsFactory systems)
        {
            Add(systems.Create<MarkDeadSystem>());
        }
    }
}