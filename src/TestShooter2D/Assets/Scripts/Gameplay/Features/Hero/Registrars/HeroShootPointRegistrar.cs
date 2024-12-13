using Infrastructure.View.Registrars;
using UnityEngine;

namespace Gameplay.Features.Hero.Registrars
{
    public class HeroShootPointRegistrar : EntityComponentRegistrar
    {
        [SerializeField] private Transform _shootPoint;

        public override void RegisterComponent()
        {
            Entity.AddHeroShootPoint(_shootPoint);
        }

        public override void UnregisterComponent()
        {
            if (Entity.hasHeroShootPoint)
                Entity.RemoveHeroShootPoint();
        }
    }
}