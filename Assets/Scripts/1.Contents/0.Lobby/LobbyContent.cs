using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyContent : IContent
{

    // ������ ��ũ��Ʈ�� �ϴ���?
    // ���̾�α� ��ũ��Ʈ��?
    // IScene : �� ��ȯ �� ������ �ε�
    // IContent : ���� ������������ �� ���̾�ε� �ε�
    // IDialog : ���� ui������




    protected override void _OnEnter() => _AddEvent();
    protected override void _OnExite() => _RemoveEvent();

    void _AddEvent()
    {
    }
    void _RemoveEvent()
    {
    }

}
