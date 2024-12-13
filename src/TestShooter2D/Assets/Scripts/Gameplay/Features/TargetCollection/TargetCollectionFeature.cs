using Gameplay.Features.TargetCollection.System;
using Infrastructure.Systems;

namespace Gameplay.Features.TargetCollection
{
    public class TargetCollectionFeature : Feature
    {
        public TargetCollectionFeature(ISystemsFactory systems)
        {
            Add(systems.Create<CastForTargetsSystem>());
            
            
            Add(systems.Create<CleanupTargetsBufferSystem>());
        }
    }
}