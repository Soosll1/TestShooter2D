//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherCanShoot;

    public static Entitas.IMatcher<GameEntity> CanShoot {
        get {
            if (_matcherCanShoot == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CanShoot);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCanShoot = matcher;
            }

            return _matcherCanShoot;
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

    static readonly Gameplay.Features.Hero.CanShoot canShootComponent = new Gameplay.Features.Hero.CanShoot();

    public bool isCanShoot {
        get { return HasComponent(GameComponentsLookup.CanShoot); }
        set {
            if (value != isCanShoot) {
                var index = GameComponentsLookup.CanShoot;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : canShootComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}
