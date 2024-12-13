using Entitas;
using Gameplay.Input.Service;
using UnityEngine;

namespace Gameplay.Features.Hero.Systems
{
    public class SetHeroDirectionSystem : IExecuteSystem
    {
        private readonly IInputService _inputService;
        private readonly IGroup<GameEntity> _heroes;

        public SetHeroDirectionSystem(GameContext game, IInputService inputService)
        {
            _inputService = inputService;
            
            _heroes = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Hero,
                    GameMatcher.WorldPosition,
                    GameMatcher.MovementAvailable));
        }

        public void Execute()
        {
            foreach (var hero in _heroes)
            {
                hero.isMoving = _inputService.HasAxisInput();

                hero.ReplaceDirection(new Vector3(_inputService.GetHorizontalAxis(), 0f, 0f));
            }
        }
    }
}