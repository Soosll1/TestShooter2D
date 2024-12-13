//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherCollectorId;

    public static Entitas.IMatcher<GameEntity> CollectorId {
        get {
            if (_matcherCollectorId == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CollectorId);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCollectorId = matcher;
            }

            return _matcherCollectorId;
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

    public Gameplay.Features.Loot.CollectorId collectorId { get { return (Gameplay.Features.Loot.CollectorId)GetComponent(GameComponentsLookup.CollectorId); } }
    public int CollectorId { get { return collectorId.Value; } }
    public bool hasCollectorId { get { return HasComponent(GameComponentsLookup.CollectorId); } }

    public GameEntity AddCollectorId(int newValue) {
        var index = GameComponentsLookup.CollectorId;
        var component = (Gameplay.Features.Loot.CollectorId)CreateComponent(index, typeof(Gameplay.Features.Loot.CollectorId));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceCollectorId(int newValue) {
        var index = GameComponentsLookup.CollectorId;
        var component = (Gameplay.Features.Loot.CollectorId)CreateComponent(index, typeof(Gameplay.Features.Loot.CollectorId));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveCollectorId() {
        RemoveComponent(GameComponentsLookup.CollectorId);
        return this;
    }
}
