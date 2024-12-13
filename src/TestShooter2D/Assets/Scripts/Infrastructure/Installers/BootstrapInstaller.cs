using Gameplay.Common.Camera;
using Gameplay.Common.Collisions;
using Gameplay.Common.Physics;
using Gameplay.Common.Random;
using Gameplay.Common.Time;
using Gameplay.Features.Armament.Factory;
using Gameplay.Features.Enemy.Factory;
using Gameplay.Features.Hero.Factory;
using Gameplay.Features.Loot.Factory;
using Gameplay.Input.Service;
using Gameplay.Levels;
using Infrastructure.AssetManagement;
using Infrastructure.Identifiers;
using Infrastructure.Loading;
using Infrastructure.SoundManagement;
using Infrastructure.States;
using Infrastructure.States.GameStates;
using Infrastructure.Systems;
using Infrastructure.View.Factory;
using Zenject;

namespace Infrastructure.Installers
{
    public class BootstrapInstaller : MonoInstaller, ICoroutineRunner
    {
        public override void InstallBindings()
        {
            BindInputService();
            BindInfrastructureServices();
            BindAssetManagementServices();
            BindCommonServices();
            BindContexts();
            BindGameplayServices();
            BindSystemFactory();
            BindFactories();
            BindCameraProvider();
            BindGameStateMachine();
        }

        private void BindGameStateMachine()
        {
            Container.Bind<IGameStateMachine>().To<GameStateMachine>().AsSingle();
            Container.Bind<BootstrapState>().AsSingle();
            Container.Bind<LoadLevelState>().AsSingle();
            Container.Bind<BattleState>().AsSingle();
            Container.Bind<GameOverState>().AsSingle();
        }

        private void BindFactories()
        {
            Container.Bind<IViewFactory>().To<ViewFactory>().AsSingle();
            Container.Bind<IHeroFactory>().To<HeroFactory>().AsSingle();
            Container.Bind<IArmamentFactory>().To<ArmamentFactory>().AsSingle();
            Container.Bind<IEnemyFactory>().To<EnemyFactory>().AsSingle();
            Container.Bind<ILootFactory>().To<LootFactory>().AsSingle();
        }

        private void BindContexts()
        {
            Container.Bind<Contexts>().FromInstance(Contexts.sharedInstance).AsSingle();

            Container.Bind<GameContext>().FromInstance(Contexts.sharedInstance.game).AsSingle();
        }

        private void BindGameplayServices()
        {
            Container.Bind<ILevelDataProvider>().To<LevelDataProvider>().AsSingle();
            Container.Bind<IStaticDataService>().To<StaticDataService>().AsSingle();
        }

        private void BindInfrastructureServices()
        {
            Container.BindInterfacesTo<BootstrapInstaller>().FromInstance(this).AsSingle();
            Container.Bind<IIdentifierService>().To<IdentifierService>().AsSingle();
        }

        private void BindAssetManagementServices()
        {
            Container.Bind<IAssetProvider>().To<AssetProvider>().AsSingle();
        }

        private void BindSystemFactory() =>
            Container.Bind<ISystemsFactory>().To<SystemsFactory>().AsSingle();

        private void BindCommonServices()
        {
            Container.Bind<IRandomService>().To<UnityRandomService>().AsSingle();
            Container.Bind<ICollisionRegistry>().To<CollisionRegistry>().AsSingle();
            Container.Bind<IPhysicsService>().To<PhysicsService>().AsSingle();
            Container.Bind<ITimeService>().To<UnityTimeService>().AsSingle();
            Container.Bind<ISceneLoader>().To<SceneLoader>().AsSingle();
        }

        private void BindInputService()
        {
            Container.Bind<IInputService>().To<StandaloneInputService>().AsSingle();
        }

        private void BindCameraProvider()
        {
            Container.Bind<ICameraProvider>().To<CameraProvider>().AsSingle();
        }
    }
}