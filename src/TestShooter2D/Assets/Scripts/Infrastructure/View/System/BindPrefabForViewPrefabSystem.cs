using System.Collections.Generic;
using Entitas;
using Infrastructure.View.Factory;

namespace Infrastructure.View.System
{
    public class BindPrefabForViewPrefabSystem : IExecuteSystem
    {
        private readonly IViewFactory _viewFactory;
        private readonly IGroup<GameEntity> _entities;
        private List<GameEntity> _buffer = new(16);

        public BindPrefabForViewPrefabSystem(GameContext game, IViewFactory viewFactory)
        {
            _viewFactory = viewFactory;
            
            _entities = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.ViewPrefab)
                .NoneOf(
                    GameMatcher.View));
        }

        public void Execute()
        {
            foreach (var entity in _entities.GetEntities(_buffer))
                _viewFactory.CreateViewFromPrefab(entity);
        }
    }
}