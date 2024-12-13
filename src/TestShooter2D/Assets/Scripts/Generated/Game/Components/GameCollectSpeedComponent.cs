//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherCollectSpeed;

    public static Entitas.IMatcher<GameEntity> CollectSpeed {
        get {
            if (_matcherCollectSpeed == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CollectSpeed);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCollectSpeed = matcher;
            }

            return _matcherCollectSpeed;
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

    public Gameplay.Features.Loot.CollectSpeed collectSpeed { get { return (Gameplay.Features.Loot.CollectSpeed)GetComponent(GameComponentsLookup.CollectSpeed); } }
    public float CollectSpeed { get { return collectSpeed.Value; } }
    public bool hasCollectSpeed { get { return HasComponent(GameComponentsLookup.CollectSpeed); } }

    public GameEntity AddCollectSpeed(float newValue) {
        var index = GameComponentsLookup.CollectSpeed;
        var component = (Gameplay.Features.Loot.CollectSpeed)CreateComponent(index, typeof(Gameplay.Features.Loot.CollectSpeed));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceCollectSpeed(float newValue) {
        var index = GameComponentsLookup.CollectSpeed;
        var component = (Gameplay.Features.Loot.CollectSpeed)CreateComponent(index, typeof(Gameplay.Features.Loot.CollectSpeed));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveCollectSpeed() {
        RemoveComponent(GameComponentsLookup.CollectSpeed);
        return this;
    }
}