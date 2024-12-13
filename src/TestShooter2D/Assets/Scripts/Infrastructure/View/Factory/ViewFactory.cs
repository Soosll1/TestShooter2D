using UnityEngine;
using Zenject;

namespace Infrastructure.View.Factory
{
    public class ViewFactory : IViewFactory
    {
        private readonly IInstantiator _instantiator;

        private Vector3 _farAway = new Vector3(-999, 999, 0);

        public ViewFactory(IInstantiator instantiator)
        {
            _instantiator = instantiator;
        }

        public void CreateViewFromPrefab(GameEntity entity)
        {
            var prefab = entity.ViewPrefab;

            var view = _instantiator.InstantiatePrefabForComponent<EntityBehaviour>(
                prefab,
                _farAway, 
                Quaternion.identity,
                null);
            
            view.SetEntity(entity);
        }
    }
}