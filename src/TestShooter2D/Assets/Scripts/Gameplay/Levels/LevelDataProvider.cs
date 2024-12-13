using Infrastructure.SoundManagement;
using Infrastructure.UI.Presenters;
using UnityEngine;

namespace Gameplay.Levels
{
    public class LevelDataProvider : ILevelDataProvider
    {
        public SoundService SoundService { get; private set; }
        public Vector3 StartPoint { get; private set; }
        public Transform[] SpawnPoints { get; private set; }
        public GameOverPresenter GameOverPresenter { get; private set; }

        public void SetStartPoint(Vector3 startPoint)
        {
            StartPoint = startPoint;
        }

        public void SetSoundService(SoundService soundService)
        {
            SoundService = soundService;
        }

        public void SetGameOverPresenter(GameOverPresenter gameOverPresenter)
        {
            GameOverPresenter = gameOverPresenter;
        }

        public void SetEnemyStartPoints(Transform[] startPoints)
        {
            SpawnPoints = startPoints;
        }
    }
}