using Gameplay.Common.Camera;
using Gameplay.Levels;
using Infrastructure.SoundManagement;
using Infrastructure.UI.Presenters;
using UnityEngine;
using Zenject;

namespace Infrastructure.Installers
{
    public class LevelInitializer : MonoBehaviour, IInitializable
    {
        public Camera MainCamera;
        public Transform StartPoint;
        public Transform[] EnemySpawnPoints;
        public SoundService SoundService;
        public GameOverPresenter GameOverPresenter;
        private ILevelDataProvider _levelDataProvider;
        private ICameraProvider _cameraProvider;

        [Inject]
        private void Construct(ILevelDataProvider levelDataProvider, ICameraProvider cameraProvider)
        {
            _levelDataProvider = levelDataProvider;
            _cameraProvider = cameraProvider;
        }

        public void Initialize()
        {
            _levelDataProvider.SetStartPoint(StartPoint.position);
            _levelDataProvider.SetEnemyStartPoints(EnemySpawnPoints);
            _levelDataProvider.SetSoundService(SoundService);
            _levelDataProvider.SetGameOverPresenter(GameOverPresenter);
            _cameraProvider.Camera = MainCamera;
        }
    }
}