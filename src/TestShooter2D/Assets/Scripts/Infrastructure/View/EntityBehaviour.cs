using Gameplay.Common.Collisions;
using Infrastructure.View.Registrars;
using UnityEngine;
using Zenject;

namespace Infrastructure.View
{
    public class EntityBehaviour : MonoBehaviour, IEntityView
    {
        private GameEntity _entity;
        public GameEntity Entity => _entity;
        
        private ICollisionRegistry _collisionRegistry;

        [Inject]
        public void Construct(ICollisionRegistry collisionRegistry) => 
            _collisionRegistry = collisionRegistry;

        public void SetEntity(GameEntity entity)
        {
            _entity = entity;
            _entity.AddView(this);
            _entity.Retain(this);

            foreach (var registrar in GetComponentsInChildren<IEntityComponentRegistrar>())
                registrar.RegisterComponent();

            foreach (var collider in GetComponentsInChildren<Collider2D>(true))
              _collisionRegistry.Register(collider.GetInstanceID(), entity);   
        }

        public void ReleaseEntity()
        {
            foreach (var registrar in GetComponentsInChildren<IEntityComponentRegistrar>())
                registrar.UnregisterComponent();
            
            foreach (var collider in GetComponentsInChildren<Collider2D>(true))
                _collisionRegistry.Unregister(collider.GetInstanceID()); 
            
            _entity.Release(this);
            _entity = null;
        }

        public GameObject GameObject => gameObject;
    }
}