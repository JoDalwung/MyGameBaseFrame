using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyContent : IContent
{
    
    public IDialogLoader dialogLoader;


    protected override void _OnLoad()
    {
        Debug.Log($"_OnLoad : {IScene.SceneName.LobbyScene}");
        dialogLoader.LoadDialog();

    }

    protected override void _OnLoadComplete()
    {
        Debug.Log($"_OnLoadComplete : {IScene.SceneName.LobbyScene}");
        dialogLoader.ShowDialog();
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
