using Common.Entity;
using Common.Extensions;
using Infrastructure.Identifiers;
using Infrastructure.View;
using UnityEngine;
using Zenject;

namespace Gameplay.Features.UI.Behaviours
{
    public class HUDSelfInitializer : MonoBehaviour
    {
        public EntityBehaviour EntityBehaviour;

        public PlayerHUD PlayerHUD;
        
        private IIdentifierService _identifiers;

        [Inject]
        public void Construct(IIdentifierService identifiers)
        {
            _identifiers = identifiers;
        }
        
        private void Awake()
        {
            var entity = CreateEntity.Empty()
                .AddId(_identifiers.Next())
                .AddPlayerHUD(PlayerHUD)
                .With(x => x.isHUD = true);
            
            EntityBehaviour.SetEntity(entity);
            
        }
    }
}