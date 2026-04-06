using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyContent : BaseContent
{
    
    public BaseDialogLoader DialogLoader;

    protected override void _OnLoad()
    {
        DialogLoader.LoadDialog();
    }

    protected override void _OnLoadComplete()
    {
        DialogLoader.ShowIdxDialog(); 
    }

    protected override void _OnEnter()
    {
        _AddEvent();
    } 
    protected override void _OnExit()
    {
        DialogLoader.UnLoadDialog();
        _RemoveEvent();
    }



    void _AddEvent(){}
    void _RemoveEvent(){}

}
