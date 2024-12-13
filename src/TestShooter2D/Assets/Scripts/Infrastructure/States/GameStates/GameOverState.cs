using Entitas;
using Gameplay.Common.Time;
using Gameplay.Levels;
using Infrastructure.States.GameStates.Common;
using UnityEngine;

namespace Infrastructure.States.GameStates
{
    public class GameOverState : IState
    {
        private readonly GameContext _game;
        private readonly ILevelDataProvider _levelDataProvider;
        private readonly ITimeService _time;

        public GameOverState(GameContext game, ILevelDataProvider levelDataProvider, ITimeService time)
        {
            _game = game;
            _levelDataProvider = levelDataProvider;
            _time = time;
        }
        
        public void Enter()
        {
            ShowGameOver();
            DestroyAllEntities();
            
        }

        private void ShowGameOver()
        {
            _levelDataProvider.GameOverPresenter.Show();
        }

        private void StopTime()
        {
            _time.StopTime();
        }

        private void DestroyAllEntities()
        {
            foreach (var entity in Contexts.sharedInstance.game.GetEntities())
            {
                if (entity.hasView)
                {
                    Object.Destroy(entity.View.GameObject);
                }
                    
                entity.Destroy();
            }
        }

        public void Exit()
        {
            
        }
    }
}