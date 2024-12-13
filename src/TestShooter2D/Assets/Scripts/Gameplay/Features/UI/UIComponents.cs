using Entitas;
using Gameplay.Features.UI.Behaviours;

namespace Gameplay.Features.UI
{
    [Game] public class HUD : IComponent { }
    [Game] public class PlayerHUDComponent : IComponent { public PlayerHUD Value; }

}