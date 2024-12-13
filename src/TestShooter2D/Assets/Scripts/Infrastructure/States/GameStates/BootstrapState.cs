using Infrastructure.AssetManagement;
using Infrastructure.Loading;
using Infrastructure.States.GameStates.Common;

namespace Infrastructure.States.GameStates
{
    public class BootstrapState : IState
    {
        private readonly IGameStateMachine _stateMachine;

        public BootstrapState(IGameStateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }

        public void Enter()
        {
            EnterLoadLevelState();
        }

        public void Exit()
        {
            
        }

        private void EnterLoadLevelState()
        {
            _stateMachine.Enter<LoadLevelState, string>(Scenes.City);
        }
    }
}