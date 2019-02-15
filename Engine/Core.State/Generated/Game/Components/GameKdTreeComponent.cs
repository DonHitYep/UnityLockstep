//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity kdTreeEntity { get { return GetGroup(GameMatcher.KdTree).GetSingleEntity(); } }
    public Lockstep.Core.State.Game.KdTreeComponent kdTree { get { return kdTreeEntity.kdTree; } }
    public bool hasKdTree { get { return kdTreeEntity != null; } }

    public GameEntity SetKdTree(bool newDirty, Lockstep.Core.State.AgentTreeNode[] newAgentTree) {
        if (hasKdTree) {
            throw new Entitas.EntitasException("Could not set KdTree!\n" + this + " already has an entity with Lockstep.Core.State.Game.KdTreeComponent!",
                "You should check if the context already has a kdTreeEntity before setting it or use context.ReplaceKdTree().");
        }
        var entity = CreateEntity();
        entity.AddKdTree(newDirty, newAgentTree);
        return entity;
    }

    public void ReplaceKdTree(bool newDirty, Lockstep.Core.State.AgentTreeNode[] newAgentTree) {
        var entity = kdTreeEntity;
        if (entity == null) {
            entity = SetKdTree(newDirty, newAgentTree);
        } else {
            entity.ReplaceKdTree(newDirty, newAgentTree);
        }
    }

    public void RemoveKdTree() {
        kdTreeEntity.Destroy();
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

    public Lockstep.Core.State.Game.KdTreeComponent kdTree { get { return (Lockstep.Core.State.Game.KdTreeComponent)GetComponent(GameComponentsLookup.KdTree); } }
    public bool hasKdTree { get { return HasComponent(GameComponentsLookup.KdTree); } }

    public void AddKdTree(bool newDirty, Lockstep.Core.State.AgentTreeNode[] newAgentTree) {
        var index = GameComponentsLookup.KdTree;
        var component = (Lockstep.Core.State.Game.KdTreeComponent)CreateComponent(index, typeof(Lockstep.Core.State.Game.KdTreeComponent));
        component.Dirty = newDirty;
        component.AgentTree = newAgentTree;
        AddComponent(index, component);
    }

    public void ReplaceKdTree(bool newDirty, Lockstep.Core.State.AgentTreeNode[] newAgentTree) {
        var index = GameComponentsLookup.KdTree;
        var component = (Lockstep.Core.State.Game.KdTreeComponent)CreateComponent(index, typeof(Lockstep.Core.State.Game.KdTreeComponent));
        component.Dirty = newDirty;
        component.AgentTree = newAgentTree;
        ReplaceComponent(index, component);
    }

    public void RemoveKdTree() {
        RemoveComponent(GameComponentsLookup.KdTree);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherKdTree;

    public static Entitas.IMatcher<GameEntity> KdTree {
        get {
            if (_matcherKdTree == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.KdTree);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherKdTree = matcher;
            }

            return _matcherKdTree;
        }
    }
}
