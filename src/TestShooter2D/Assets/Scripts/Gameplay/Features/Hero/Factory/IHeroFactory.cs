using UnityEngine;

namespace Gameplay.Features.Hero.Factory
{
    public interface IHeroFactory
    {
        GameEntity CreateHero(Vector3 at);
    }
}