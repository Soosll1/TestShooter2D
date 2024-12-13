//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherTimeBetweenShoots;

    public static Entitas.IMatcher<GameEntity> TimeBetweenShoots {
        get {
            if (_matcherTimeBetweenShoots == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.TimeBetweenShoots);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTimeBetweenShoots = matcher;
            }

            return _matcherTimeBetweenShoots;
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

    public Gameplay.Features.Hero.TimeBetweenShoots timeBetweenShoots { get { return (Gameplay.Features.Hero.TimeBetweenShoots)GetComponent(GameComponentsLookup.TimeBetweenShoots); } }
    public float TimeBetweenShoots { get { return timeBetweenShoots.Value; } }
    public bool hasTimeBetweenShoots { get { return HasComponent(GameComponentsLookup.TimeBetweenShoots); } }

    public GameEntity AddTimeBetweenShoots(float newValue) {
        var index = GameComponentsLookup.TimeBetweenShoots;
        var component = (Gameplay.Features.Hero.TimeBetweenShoots)CreateComponent(index, typeof(Gameplay.Features.Hero.TimeBetweenShoots));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceTimeBetweenShoots(float newValue) {
        var index = GameComponentsLookup.TimeBetweenShoots;
        var component = (Gameplay.Features.Hero.TimeBetweenShoots)CreateComponent(index, typeof(Gameplay.Features.Hero.TimeBetweenShoots));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveTimeBetweenShoots() {
        RemoveComponent(GameComponentsLookup.TimeBetweenShoots);
        return this;
    }
}