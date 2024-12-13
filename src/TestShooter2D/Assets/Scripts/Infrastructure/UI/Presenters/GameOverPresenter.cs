using System;
using Infrastructure.Loading;
using Infrastructure.States;
using Infrastructure.States.GameStates;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Infrastructure.UI.Presenters
{
    public class GameOverPresenter : MonoBehaviour
    {
        [SerializeField] private GameOverPanel _gameOverPanel;
        
        private IGameStateMachine _gameStateMachine;

        [Inject]
        public void Construct(IGameStateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
        }
        
        private void OnEnable()
        {
            _gameOverPanel.RestartButton.onClick.AddListener(RestartGame);
            _gameOverPanel.QuitGameButton.onClick.AddListener(QuitGame);
        }

        private void OnDisable()
        {
            _gameOverPanel.RestartButton.onClick.RemoveListener(RestartGame);
            _gameOverPanel.QuitGameButton.onClick.RemoveListener(QuitGame);
        }

        public void Show()
        {
            _gameOverPanel.gameObject.SetActive(true);
        }
        
        private void RestartGame()
        {
            SceneManager.LoadScene(Scenes.Bootstrap);
        }

        private void QuitGame()
        {
            Application.Quit();
        }
    }
}