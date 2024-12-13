using UnityEngine;

namespace Gameplay.Features.Armament.Factory
{
    public interface IArmamentFactory
    {
        GameEntity CreateProjectile(Vector3 at);
    }
}