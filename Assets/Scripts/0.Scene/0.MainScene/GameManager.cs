using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : BaseScene
{
    // 어떤식으로 쓸지 미정
    public List<SceneName> SceneList;    
    public SceneName EntryScene;
    protected override void _OnLoad()
    {
        base._OnLoad();

        
        PlayerInfo.Instance.Name = "Player";
    }

    protected override void _OnLoadComplete()
    {
        ActiveScene(EntryScene , true);
    }

    protected override void _OnEnter() => _AddEvent();
    protected override void _OnExite() => _RemoveEvent();

    void _AddEvent()
    {


    }

    void _RemoveEvent()
    {
    

    }





}
