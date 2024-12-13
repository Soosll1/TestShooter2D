using System.Collections.Generic;
using System.Linq;
using Gameplay.Features.Armament.Configs;
using Gameplay.Features.Enemy.Configs;
using Gameplay.Features.Hero.Configs;
using Gameplay.Features.Loot.Configs;
using UnityEngine;

namespace Infrastructure.AssetManagement
{
    public class StaticDataService : IStaticDataService
    {
        private HeroConfig _heroConfig;
        private LootConfig _lootConfig;
        private ArmamentConfig _armamentConfig;
        private Dictionary<EnemyTypeId, EnemyConfig> _enemiesConfigs;

        public void LoadAll()
        {
            LoadHero();
            LoadArmament();
            LoadEnemies();
            LoadLoot();
        }

        #region Hero
        
        private void LoadHero()
        {
            _heroConfig = Resources.Load<HeroConfig>(AssetPath.HeroPath);
        }

        public HeroConfig GetHeroConfig() =>
            _heroConfig;

        #endregion
        
        #region Armament
        
        private void LoadArmament()
        {
            _armamentConfig = Resources.Load<ArmamentConfig>(AssetPath.ArmamentPath);
        }

        public ArmamentConfig GetArmamentConfig() =>
            _armamentConfig;

        #endregion
        
        #region Enemy
        
        private void LoadEnemies()
        {
            _enemiesConfigs = Resources.LoadAll<EnemyConfig>(AssetPath.EnemiesPath).ToDictionary(x => x.ZombieTypeId, x => x);
        }

        public EnemyConfig GetEnemyConfigById(EnemyTypeId typeId) =>
            _enemiesConfigs.TryGetValue(typeId, out EnemyConfig config) ? config : null;

        #endregion
        
        #region Loot
        
        private void LoadLoot()
        {
            _lootConfig = Resources.Load<LootConfig>(AssetPath.LootPath);
        }

        public LootConfig GetLootConfig() =>
            _lootConfig;

        #endregion
    }
}