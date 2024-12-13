using System.Collections.Generic;
using Common.Extensions;
using Entitas;
using Gameplay.Features.Armament.Factory;
using Gameplay.Levels;
using UnityEngine;

namespace Gameplay.Features.Hero.Systems
{
    public class HeroShootSystem : IExecuteSystem
    {
        private readonly IArmamentFactory _armamentFactory;
        private readonly ILevelDataProvider _levelDataProvider;
        private readonly IGroup<GameEntity> _inputs;
        private readonly IGroup<GameEntity> _heroes;

        private List<GameEntity> _buffer = new(4);

        public HeroShootSystem(GameContext game, IArmamentFactory armamentFactory, ILevelDataProvider levelDataProvider)
        {
            _armamentFactory = armamentFactory;
            _levelDataProvider = levelDataProvider;

            _inputs = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Input,
                    GameMatcher.LeftButtonInput));
            
            _heroes = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Hero,
                    GameMatcher.CanShoot,
                    GameMatcher.AmmoCount,
                    GameMatcher.AmmoCurrent)
                .NoneOf(
                    GameMatcher.NoAmmo));
        }

        public void Execute()
        {
            foreach (var input in _inputs)
            foreach (var hero in _heroes.GetEntities(_buffer))
            {
                var shootPoint = hero.HeroShootPoint;

                var direction = new Vector3(shootPoint.position.x - hero.WorldPosition.x, 0f, 0f);
                
                _armamentFactory.CreateProjectile(hero.HeroShootPoint.position)
                    .AddDirection(direction.normalized)
                    .With(x => x.isMoving = true);

                hero.ReplaceAmmoCurrent(hero.AmmoCurrent - 1);
                
                hero.ReplaceShootTimeLeft(hero.TimeBetweenShoots);
                hero.isCanShoot = false;
                _levelDataProvider.SoundService.PlayShoot();
            }
        }
    }
}