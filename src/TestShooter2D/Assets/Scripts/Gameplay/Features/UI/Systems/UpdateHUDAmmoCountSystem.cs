using Entitas;

namespace Gameplay.Features.UI.Systems
{
    public class UpdateHUDAmmoCountSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _HUDs;
        private readonly IGroup<GameEntity> _heroes;

        public UpdateHUDAmmoCountSystem(GameContext game)
        {
            _HUDs = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.HUD,
                    GameMatcher.PlayerHUD,
                    GameMatcher.AmmoCount));

            _heroes = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Hero,
                    GameMatcher.AmmoCount,
                    GameMatcher.WorldPosition));
        }

        public void Execute()
        {
            foreach (var hero in _heroes)
            foreach (var huD in _HUDs)
            {
                huD.PlayerHUD.SetCount(hero.AmmoCurrent.ToString());
            }
        }
    }
}