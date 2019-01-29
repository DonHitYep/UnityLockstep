//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Lockstep.Core.Interfaces;

public partial class InputContext {

    public InputEntity commandsEntity { get { return GetGroup(InputMatcher.Commands).GetSingleEntity(); } }
    public Lockstep.Core.Components.Input.CommandsComponent commands { get { return commandsEntity.commands; } }
    public bool hasCommands { get { return commandsEntity != null; } }

    public InputEntity SetCommands(ICommand[] newInput) {
        if (hasCommands) {
            throw new Entitas.EntitasException("Could not set Commands!\n" + this + " already has an entity with Lockstep.Core.Components.Input.CommandsComponent!",
                "You should check if the context already has a commandsEntity before setting it or use context.ReplaceCommands().");
        }
        var entity = CreateEntity();
        entity.AddCommands(newInput);
        return entity;
    }

    public void ReplaceCommands(ICommand[] newInput) {
        var entity = commandsEntity;
        if (entity == null) {
            entity = SetCommands(newInput);
        } else {
            entity.ReplaceCommands(newInput);
        }
    }

    public void RemoveCommands() {
        commandsEntity.Destroy();
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
public partial class InputEntity {

    public Lockstep.Core.Components.Input.CommandsComponent commands { get { return (Lockstep.Core.Components.Input.CommandsComponent)GetComponent(InputComponentsLookup.Commands); } }
    public bool hasCommands { get { return HasComponent(InputComponentsLookup.Commands); } }

    public void AddCommands(ICommand[] newInput) {
        var index = InputComponentsLookup.Commands;
        var component = (Lockstep.Core.Components.Input.CommandsComponent)CreateComponent(index, typeof(Lockstep.Core.Components.Input.CommandsComponent));
        component.input = newInput;
        AddComponent(index, component);
    }

    public void ReplaceCommands(ICommand[] newInput) {
        var index = InputComponentsLookup.Commands;
        var component = (Lockstep.Core.Components.Input.CommandsComponent)CreateComponent(index, typeof(Lockstep.Core.Components.Input.CommandsComponent));
        component.input = newInput;
        ReplaceComponent(index, component);
    }

    public void RemoveCommands() {
        RemoveComponent(InputComponentsLookup.Commands);
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
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherCommands;

    public static Entitas.IMatcher<InputEntity> Commands {
        get {
            if (_matcherCommands == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.Commands);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherCommands = matcher;
            }

            return _matcherCommands;
        }
    }
}
