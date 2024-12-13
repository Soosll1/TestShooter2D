using Infrastructure.View.Registrars;
using UnityEngine;

namespace Gameplay.Features.Loot.Registrars
{
    public class DropPointRegistrar : EntityComponentRegistrar
    {
        [SerializeField] private Transform _point;
        
        public override void RegisterComponent()
        {
            Entity.AddDropPoint(_point);
        }

        public override void UnregisterComponent()
        {
            if (Entity.hasDropPoint)
                Entity.RemoveDropPoint();
        }
    }
}