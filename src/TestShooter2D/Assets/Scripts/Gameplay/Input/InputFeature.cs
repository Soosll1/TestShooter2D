using Gameplay.Input.Service;
using Gameplay.Input.Systems;
using Infrastructure.Systems;

namespace Gameplay.Input
{
    public class InputFeature : Feature
    {
        public InputFeature(ISystemsFactory systems)
        {
            Add(systems.Create<InitializeInputSystem>());
            Add(systems.Create<EmitInputSystem>());
        }
    }
}