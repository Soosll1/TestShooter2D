using Infrastructure.View.Registrars;
using UnityEngine;

namespace Gameplay.Common.Registrars
{
    public class SpriteRendererRegistrar : EntityComponentRegistrar
    {
        [SerializeField] private SpriteRenderer _spriteRenderer;

        public override void RegisterComponent()
        {
            Entity.AddSpriteRenderer(_spriteRenderer);
        }

        public override void UnregisterComponent()
        {
            if (Entity.hasSpriteRenderer)
                Entity.RemoveSpriteRenderer();
        }
    }
}