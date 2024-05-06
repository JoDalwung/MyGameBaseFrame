using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_1Content : IContent
{
    public IDialogLoader dialogLoader;

    protected override void _OnLoad()
    {
        dialogLoader.LoadDialog();
    }

    protected override void _OnLoadComplete()
    {
        dialogLoader.ShowIdxDialog(); 
    }

    protected override void _OnEnter()
    {
        _AddEvent();
    } 
    protected override void _OnExite()
    {
        dialogLoader.AllHideDialog();
        _RemoveEvent();
    }


    void _AddEvent(){}
    void _RemoveEvent(){}
}

