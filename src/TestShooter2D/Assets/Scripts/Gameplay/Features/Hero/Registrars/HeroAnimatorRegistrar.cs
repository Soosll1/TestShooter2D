using Infrastructure.View.Registrars;
using UnityEngine;

namespace Gameplay.Features.Hero.Registrars
{
    public class HeroAnimatorRegistrar : EntityComponentRegistrar
    {
        [SerializeField] private HeroAnimator _animator;

        public override void RegisterComponent()
        {
            Entity.AddHeroAnimator(_animator);
        }

        public override void UnregisterComponent()
        {
            if (Entity.hasHeroAnimator)
                Entity.RemoveHeroAnimator();
        }
    }
}