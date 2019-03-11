//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public MyBoolComponent myBool { get { return (MyBoolComponent)GetComponent(GameComponentsLookup.MyBool); } }
    public bool hasMyBool { get { return HasComponent(GameComponentsLookup.MyBool); } }

    public void AddMyBool(bool newMyBool) {
        var index = GameComponentsLookup.MyBool;
        var component = (MyBoolComponent)CreateComponent(index, typeof(MyBoolComponent));
        component.myBool = newMyBool;
        AddComponent(index, component);
    }

    public void ReplaceMyBool(bool newMyBool) {
        var index = GameComponentsLookup.MyBool;
        var component = (MyBoolComponent)CreateComponent(index, typeof(MyBoolComponent));
        component.myBool = newMyBool;
        ReplaceComponent(index, component);
    }

    public void RemoveMyBool() {
        RemoveComponent(GameComponentsLookup.MyBool);
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

    static Entitas.IMatcher<GameEntity> _matcherMyBool;

    public static Entitas.IMatcher<GameEntity> MyBool {
        get {
            if (_matcherMyBool == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MyBool);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMyBool = matcher;
            }

            return _matcherMyBool;
        }
    }
}
