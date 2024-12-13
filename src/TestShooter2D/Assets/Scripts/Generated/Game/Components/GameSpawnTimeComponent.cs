//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherSpawnTime;

    public static Entitas.IMatcher<GameEntity> SpawnTime {
        get {
            if (_matcherSpawnTime == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SpawnTime);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSpawnTime = matcher;
            }

            return _matcherSpawnTime;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Gameplay.Features.Enemy.SpawnTime spawnTime { get { return (Gameplay.Features.Enemy.SpawnTime)GetComponent(GameComponentsLookup.SpawnTime); } }
    public float SpawnTime { get { return spawnTime.Value; } }
    public bool hasSpawnTime { get { return HasComponent(GameComponentsLookup.SpawnTime); } }

    public GameEntity AddSpawnTime(float newValue) {
        var index = GameComponentsLookup.SpawnTime;
        var component = (Gameplay.Features.Enemy.SpawnTime)CreateComponent(index, typeof(Gameplay.Features.Enemy.SpawnTime));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceSpawnTime(float newValue) {
        var index = GameComponentsLookup.SpawnTime;
        var component = (Gameplay.Features.Enemy.SpawnTime)CreateComponent(index, typeof(Gameplay.Features.Enemy.SpawnTime));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveSpawnTime() {
        RemoveComponent(GameComponentsLookup.SpawnTime);
        return this;
    }
}
