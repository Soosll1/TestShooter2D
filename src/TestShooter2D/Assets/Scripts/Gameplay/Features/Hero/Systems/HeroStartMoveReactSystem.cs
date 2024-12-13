﻿using System.Collections.Generic;
using Entitas;
using Gameplay.Levels;

namespace Gameplay.Features.Hero.Systems
{
   public class HeroStartMoveReactSystem : ReactiveSystem<GameEntity>
   {
      private readonly ILevelDataProvider _levelDataProvider;

      public HeroStartMoveReactSystem(GameContext game, ILevelDataProvider levelDataProvider) : base(game)
      {
         _levelDataProvider = levelDataProvider;
      }

      protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
      {
         return context.CreateCollector(GameMatcher
            .AllOf(
               GameMatcher.Hero,
               GameMatcher.Moving)
            .Added());
      }

      protected override bool Filter(GameEntity entity)
      {
         return entity.isMoving && entity.isHero;
      }

      protected override void Execute(List<GameEntity> entities)
      {
         foreach (var entity in entities)
         {
            _levelDataProvider.SoundService.PlayHeroMove(true);

         }
      }
   }
}