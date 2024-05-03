using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyDialog : IDialog
{
    protected override void _OnEnter() => _AddEvent();
    protected override void _OnExite() => _RemoveEvent();
    void _AddEvent()
    {
    }
    void _RemoveEvent()
    {
    }



}
