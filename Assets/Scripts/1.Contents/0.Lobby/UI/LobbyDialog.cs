using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LobbyDialog : IDialog
{

    protected override void _OnLoad()
    {
        // ĳ��
 
    }
    protected override void _OnLoadComplete()
    {
        // ĳ��2
    }

    protected override void _OnEnter()
    {
        // ���� �ʱ�ȭ
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
