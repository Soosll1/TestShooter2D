using Gameplay.Features.Armament.Configs;
using Gameplay.Features.Enemy.Configs;
using Gameplay.Features.Hero.Configs;
using Gameplay.Features.Loot.Configs;

namespace Infrastructure.AssetManagement
{
    public interface IStaticDataService
    {
        void LoadAll();
        HeroConfig GetHeroConfig();
        ArmamentConfig GetArmamentConfig();
        EnemyConfig GetEnemyConfigById(EnemyTypeId typeId);
        LootConfig GetLootConfig();
    }
}