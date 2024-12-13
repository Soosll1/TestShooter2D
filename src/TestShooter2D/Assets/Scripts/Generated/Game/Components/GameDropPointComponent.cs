//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherDropPoint;

    public static Entitas.IMatcher<GameEntity> DropPoint {
        get {
            if (_matcherDropPoint == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.DropPoint);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDropPoint = matcher;
            }

            return _matcherDropPoint;
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

    public Gameplay.Features.Loot.DropPoint dropPoint { get { return (Gameplay.Features.Loot.DropPoint)GetComponent(GameComponentsLookup.DropPoint); } }
    public UnityEngine.Transform DropPoint { get { return dropPoint.Value; } }
    public bool hasDropPoint { get { return HasComponent(GameComponentsLookup.DropPoint); } }

    public GameEntity AddDropPoint(UnityEngine.Transform newValue) {
        var index = GameComponentsLookup.DropPoint;
        var component = (Gameplay.Features.Loot.DropPoint)CreateComponent(index, typeof(Gameplay.Features.Loot.DropPoint));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceDropPoint(UnityEngine.Transform newValue) {
        var index = GameComponentsLookup.DropPoint;
        var component = (Gameplay.Features.Loot.DropPoint)CreateComponent(index, typeof(Gameplay.Features.Loot.DropPoint));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveDropPoint() {
        RemoveComponent(GameComponentsLookup.DropPoint);
        return this;
    }
}