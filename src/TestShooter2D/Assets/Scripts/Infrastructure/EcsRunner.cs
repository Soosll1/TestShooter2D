using Gameplay;
using Infrastructure.AssetManagement;
using Infrastructure.Installers;
using Infrastructure.Loading;
using Infrastructure.Systems;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Infrastructure
{
    public class EcsRunner : MonoBehaviour
    {
        [SerializeField] private LevelInitializer _levelInitializer;
        
        private BattleFeature _battleFeature;
        private ISystemsFactory _systemsFactory;

        [Inject]
        public void Construct(ISystemsFactory systemsFactory)
        {
            _systemsFactory = systemsFactory;
        }

        private void Awake()
        {
            _levelInitializer.Initialize();
        }

        private void Start()
        {
            _battleFeature = _systemsFactory.Create<BattleFeature>();
            _battleFeature.Initialize();
        }

        private void Update()
        {
            _battleFeature.Execute();
            _battleFeature.Cleanup();
        }

        private void OnDestroy()
        {
            _battleFeature.TearDown();
        }
    }
}