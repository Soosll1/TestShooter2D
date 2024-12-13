//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherWorldPosition;

    public static Entitas.IMatcher<GameEntity> WorldPosition {
        get {
            if (_matcherWorldPosition == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.WorldPosition);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherWorldPosition = matcher;
            }

            return _matcherWorldPosition;
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

    public Gameplay.Common.WorldPosition worldPosition { get { return (Gameplay.Common.WorldPosition)GetComponent(GameComponentsLookup.WorldPosition); } }
    public UnityEngine.Vector3 WorldPosition { get { return worldPosition.Value; } }
    public bool hasWorldPosition { get { return HasComponent(GameComponentsLookup.WorldPosition); } }

    public GameEntity AddWorldPosition(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.WorldPosition;
        var component = (Gameplay.Common.WorldPosition)CreateComponent(index, typeof(Gameplay.Common.WorldPosition));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceWorldPosition(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.WorldPosition;
        var component = (Gameplay.Common.WorldPosition)CreateComponent(index, typeof(Gameplay.Common.WorldPosition));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveWorldPosition() {
        RemoveComponent(GameComponentsLookup.WorldPosition);
        return this;
    }
}
