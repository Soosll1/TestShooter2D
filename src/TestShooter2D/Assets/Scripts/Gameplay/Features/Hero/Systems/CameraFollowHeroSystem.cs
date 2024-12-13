﻿using Entitas;
using Gameplay.Common.Camera;

namespace Gameplay.Features.Hero.Systems
{
    public class CameraFollowHeroSystem : IExecuteSystem
    {
        private readonly ICameraProvider _cameraProvider;
        private readonly IGroup<GameEntity> _heroes;

        public CameraFollowHeroSystem(GameContext game, ICameraProvider cameraProvider)
        {
            _cameraProvider = cameraProvider;
            
            _heroes = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Hero,
                    GameMatcher.WorldPosition));
        }

        public void Execute()
        {
            foreach (var hero in _heroes)
            {
                _cameraProvider.SetPositionX(hero.WorldPosition.x);
            }
        }
    }
}