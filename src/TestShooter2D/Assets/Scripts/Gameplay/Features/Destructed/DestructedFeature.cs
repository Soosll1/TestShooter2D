using Gameplay.Features.Destructed.Systems;
using Infrastructure.Systems;

namespace Gameplay.Features.Destructed
{
    public class DestructedFeature : Feature
    {
        public DestructedFeature(ISystemsFactory systems)
        {
            Add(systems.Create<SelfDestructSystem>());
            Add(systems.Create<DestructViewSystem>());
            Add(systems.Create<DestructEntitySystem>());
        }   
    }
}