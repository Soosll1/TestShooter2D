using Infrastructure.SoundManagement;
using Infrastructure.UI.Presenters;
using UnityEngine;

namespace Gameplay.Levels
{
  public interface ILevelDataProvider
  {
    SoundService SoundService { get; }
    Vector3 StartPoint { get; }
    Transform[] SpawnPoints { get; }
    GameOverPresenter GameOverPresenter { get; }
    void SetStartPoint(Vector3 startPoint);
    void SetEnemyStartPoints(Transform[] startPoints);
    void SetSoundService(SoundService soundService);
    
    void SetGameOverPresenter(GameOverPresenter gameOverPresenter);
  }
}