//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity spriteNameEntity { get { return GetGroup(GameMatcher.SpriteName).GetSingleEntity(); } }
    public SpriteNameComponent spriteName { get { return spriteNameEntity.spriteName; } }
    public bool hasSpriteName { get { return spriteNameEntity != null; } }

    public GameEntity SetSpriteName(string newValue) {
        if (hasSpriteName) {
            throw new Entitas.EntitasException("Could not set SpriteName!\n" + this + " already has an entity with SpriteNameComponent!",
                "You should check if the context already has a spriteNameEntity before setting it or use context.ReplaceSpriteName().");
        }
        var entity = CreateEntity();
        entity.AddSpriteName(newValue);
        return entity;
    }

    public void ReplaceSpriteName(string newValue) {
        var entity = spriteNameEntity;
        if (entity == null) {
            entity = SetSpriteName(newValue);
        } else {
            entity.ReplaceSpriteName(newValue);
        }
    }

    public void RemoveSpriteName() {
        spriteNameEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public SpriteNameComponent spriteName { get { return (SpriteNameComponent)GetComponent(GameComponentsLookup.SpriteName); } }
    public bool hasSpriteName { get { return HasComponent(GameComponentsLookup.SpriteName); } }

    public void AddSpriteName(string newValue) {
        var index = GameComponentsLookup.SpriteName;
        var component = CreateComponent<SpriteNameComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceSpriteName(string newValue) {
        var index = GameComponentsLookup.SpriteName;
        var component = CreateComponent<SpriteNameComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveSpriteName() {
        RemoveComponent(GameComponentsLookup.SpriteName);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherSpriteName;

    public static Entitas.IMatcher<GameEntity> SpriteName {
        get {
            if (_matcherSpriteName == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SpriteName);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSpriteName = matcher;
            }

            return _matcherSpriteName;
        }
    }
}