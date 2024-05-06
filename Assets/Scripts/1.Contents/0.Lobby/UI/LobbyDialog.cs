using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LobbyDialog : IDialog
{

    protected override void _OnLoad()
    {
        // Ä³½Ì
 
    }
    protected override void _OnLoadComplete()
    {
        // Ä³½Ì2
    }

    protected override void _OnEnter()
    {
        // »óÅÂ ÃÊ±âÈ­
        _AddEvent();      
    }
    protected override void _OnExite()
    {
        _RemoveEvent();
    }

    void _AddEvent()
    {

    }
    void _RemoveEvent()
    {

    }

}
