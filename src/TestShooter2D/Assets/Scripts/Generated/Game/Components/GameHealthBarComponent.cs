//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherHealthBar;

    public static Entitas.IMatcher<GameEntity> HealthBar {
        get {
            if (_matcherHealthBar == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.HealthBar);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherHealthBar = matcher;
            }

            return _matcherHealthBar;
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

    public Gameplay.Features.Enemy.HealthBarComponent healthBar { get { return (Gameplay.Features.Enemy.HealthBarComponent)GetComponent(GameComponentsLookup.HealthBar); } }
    public Gameplay.Features.Enemy.Behaviours.HealthBar HealthBar { get { return healthBar.Value; } }
    public bool hasHealthBar { get { return HasComponent(GameComponentsLookup.HealthBar); } }

    public GameEntity AddHealthBar(Gameplay.Features.Enemy.Behaviours.HealthBar newValue) {
        var index = GameComponentsLookup.HealthBar;
        var component = (Gameplay.Features.Enemy.HealthBarComponent)CreateComponent(index, typeof(Gameplay.Features.Enemy.HealthBarComponent));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceHealthBar(Gameplay.Features.Enemy.Behaviours.HealthBar newValue) {
        var index = GameComponentsLookup.HealthBar;
        var component = (Gameplay.Features.Enemy.HealthBarComponent)CreateComponent(index, typeof(Gameplay.Features.Enemy.HealthBarComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveHealthBar() {
        RemoveComponent(GameComponentsLookup.HealthBar);
        return this;
    }
}
