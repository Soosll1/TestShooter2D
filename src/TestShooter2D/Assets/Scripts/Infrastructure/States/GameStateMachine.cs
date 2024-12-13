using System;
using System.Collections.Generic;
using Infrastructure.Loading;
using Infrastructure.States.GameStates;
using Infrastructure.States.GameStates.Common;

namespace Infrastructure.States
{
    public class GameStateMachine : IGameStateMachine
    {
        private readonly ISceneLoader _sceneLoader;
        private IExitableState _currentState;
        private Dictionary<Type, IExitableState> _states;

        public GameStateMachine(ISceneLoader sceneLoader)
        {
            _sceneLoader = sceneLoader;
        }
        
        public void InitStates(
            BootstrapState bootstrapState,
            LoadLevelState loadLevelState,
            BattleState battleState,
            GameOverState gameOverState
            )
        {
            _states = new();
            
            _states.Add(typeof(BootstrapState), bootstrapState);
            _states.Add(typeof(LoadLevelState), loadLevelState);
            _states.Add(typeof(BattleState), battleState);
            _states.Add(typeof(GameOverState), gameOverState);
        }

        public void Enter<TState>() where TState : class, IState
        {
            var state = ChangeState<TState>();
            state.Enter();
        }

        public void Enter<TState, TPayLoad>(TPayLoad payLoad) where TState : class, IPayloadState<TPayLoad>
        {
            var state = ChangeState<TState>();
            state.Enter(payLoad);
        }
        
        private TState ChangeState<TState>() where TState : class, IExitableState
        {
            _currentState?.Exit();
            TState state = GetState<TState>();
            _currentState = state;
            return state;
        }

        private TState GetState<TState>() where TState : class, IExitableState
        {
            return _states[typeof(TState)] as TState;
        }
    }
}