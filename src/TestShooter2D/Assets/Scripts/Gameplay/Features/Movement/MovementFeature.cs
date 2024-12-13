using Gameplay.Features.Movement.Systems;
using Infrastructure.Systems;

namespace Gameplay.Features.Movement
{
    public class MovementFeature : Feature
    {
        public MovementFeature(ISystemsFactory systems)
        {
            Add(systems.Create<DirectionalMovementSystem>());
            Add(systems.Create<UpdateTransformPositionSystem>());
            Add(systems.Create<TurnAlongDirectionSystem>());
        }
    }
}