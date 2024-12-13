using Gameplay.Features.DamageApplication.Systems;
using Infrastructure.Systems;

namespace Gameplay.Features.DamageApplication
{
    public class DamageApplicationFeature : Feature
    {
        public DamageApplicationFeature(ISystemsFactory systems)
        {
            Add(systems.Create<DamageSystem>());
        }   
    }
}