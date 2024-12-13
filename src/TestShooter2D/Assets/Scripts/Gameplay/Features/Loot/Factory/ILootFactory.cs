using UnityEngine;

namespace Gameplay.Features.Loot.Factory
{
    public interface ILootFactory
    {
        GameEntity CreateLoot(Vector3 at);
    }
}