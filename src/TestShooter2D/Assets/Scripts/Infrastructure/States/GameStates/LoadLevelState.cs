using Infrastructure.AssetManagement;
using Infrastructure.Loading;
using Infrastructure.States.GameStates.Common;
using UnityEngine;

namespace Infrastructure.States.GameStates
{
    public class LoadLevelState : IPayloadState<string>
    {
        private readonly IGameStateMachine _stateMachine;
        private readonly ISceneLoader _sceneLoader;
        private readonly IStaticDataService _staticDataService;

        public LoadLevelState(IGameStateMachine stateMachine, ISceneLoader sceneLoader, IStaticDataService staticDataService)
        {
            _stateMachine = stateMachine;
            _sceneLoader = sceneLoader;
            _staticDataService = staticDataService;
        }
        
        public void Enter(string sceneName)
        {
            _staticDataService.LoadAll();
            _sceneLoader.LoadScene(sceneName, EnterBattleState);
        }

        public void Exit()
        {
            
        }

        private void EnterBattleState()
        {
            _stateMachine.Enter<BattleState>();
        }
    }
}