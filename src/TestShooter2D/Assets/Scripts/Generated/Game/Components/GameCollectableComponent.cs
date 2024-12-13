//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherCollectable;

    public static Entitas.IMatcher<GameEntity> Collectable {
        get {
            if (_matcherCollectable == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Collectable);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCollectable = matcher;
            }

            return _matcherCollectable;
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

    static readonly Gameplay.Features.Loot.Collectable collectableComponent = new Gameplay.Features.Loot.Collectable();

    public bool isCollectable {
        get { return HasComponent(GameComponentsLookup.Collectable); }
        set {
            if (value != isCollectable) {
                var index = GameComponentsLookup.Collectable;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : collectableComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}
