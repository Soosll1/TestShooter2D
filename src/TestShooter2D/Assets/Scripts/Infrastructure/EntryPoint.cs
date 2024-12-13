using System;
using Infrastructure.States;
using Infrastructure.States.GameStates;
using UnityEngine;
using Zenject;

namespace Infrastructure
{
    public class EntryPoint : MonoBehaviour
    {
        private IGameStateMachine _stateMachine;

        [Inject]
        public void Construct(
            IGameStateMachine gameStateMachine,
            BootstrapState bootstrapState,
            LoadLevelState loadLevelState,
            BattleState battleState,
            GameOverState gameOverState)
        {
            _stateMachine = gameStateMachine;
            _stateMachine.InitStates(bootstrapState, loadLevelState, battleState, gameOverState);
        }

        private void Awake()
        {
            _stateMachine.Enter<BootstrapState>();
        }
    }
}