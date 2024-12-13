using Infrastructure.Systems;
using Infrastructure.View.System;

namespace Infrastructure.View
{
    public class BindViewFeature : Feature
    {
        public BindViewFeature(ISystemsFactory systems)
        {
            Add(systems.Create<BindPrefabForViewPrefabSystem>());
        }
    }
}