using Gameplay.Features.Enemy.Behaviours;
using Infrastructure.View.Registrars;
using UnityEngine;

namespace Gameplay.Features.Enemy.Registrars
{
    public class HealthBarRegistrar : EntityComponentRegistrar
    {
        [SerializeField] private HealthBar _healthBar;
        
        public override void RegisterComponent()
        {
            Entity.AddHealthBar(_healthBar);
        }

        public override void UnregisterComponent()
        {
            if (Entity.hasHealthBar)
                Entity.RemoveHealthBar();
        }
    }
}