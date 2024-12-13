using Infrastructure.States.GameStates;
using Infrastructure.States.GameStates.Common;

namespace Infrastructure.States
{
    public interface IGameStateMachine
    {
        void InitStates(BootstrapState bootstrapState, LoadLevelState loadLevelState, BattleState battleState, GameOverState gameOverState);
        void Enter<TState>() where TState : class, IState;
        void Enter<TState, TPayLoad>(TPayLoad payLoad) where TState : class, IPayloadState<TPayLoad>;
    }
}