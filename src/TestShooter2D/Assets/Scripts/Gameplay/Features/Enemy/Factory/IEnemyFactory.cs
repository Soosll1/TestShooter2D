using UnityEngine;

namespace Gameplay.Features.Enemy.Factory
{
    public interface IEnemyFactory
    {
        GameEntity CreateRandomZombie(Vector3 at);
    }
}