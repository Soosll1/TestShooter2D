//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherHealthCurrent;

    public static Entitas.IMatcher<GameEntity> HealthCurrent {
        get {
            if (_matcherHealthCurrent == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.HealthCurrent);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherHealthCurrent = matcher;
            }

            return _matcherHealthCurrent;
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

    public Gameplay.Common.HealthCurrent healthCurrent { get { return (Gameplay.Common.HealthCurrent)GetComponent(GameComponentsLookup.HealthCurrent); } }
    public float HealthCurrent { get { return healthCurrent.Value; } }
    public bool hasHealthCurrent { get { return HasComponent(GameComponentsLookup.HealthCurrent); } }

    public GameEntity AddHealthCurrent(float newValue) {
        var index = GameComponentsLookup.HealthCurrent;
        var component = (Gameplay.Common.HealthCurrent)CreateComponent(index, typeof(Gameplay.Common.HealthCurrent));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceHealthCurrent(float newValue) {
        var index = GameComponentsLookup.HealthCurrent;
        var component = (Gameplay.Common.HealthCurrent)CreateComponent(index, typeof(Gameplay.Common.HealthCurrent));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveHealthCurrent() {
        RemoveComponent(GameComponentsLookup.HealthCurrent);
        return this;
    }
}