using Gameplay.Features.UI.Systems;
using Infrastructure.Systems;

namespace Gameplay.Features.UI
{
    public class UIFeature : Feature
    {
        public UIFeature(ISystemsFactory systems)
        {
            Add(systems.Create<HUDInitReactSystem>());
            Add(systems.Create<UpdateHUDAmmoCountSystem>());
        }
    }
}