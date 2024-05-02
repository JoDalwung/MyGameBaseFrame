using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyContent : IContent
{

    // 컨탠츠 스크립트가 하는일?
    // 다이얼로그 스크립트는?
    // IScene : 씬 전환 및 컨탠츠 로드
    // IContent : 게임 컨탠츠구현부 및 다이얼로드 로드
    // IDialog : 게임 ui구현부




    protected override void _OnEnter() => _AddEvent();
    protected override void _OnExite() => _RemoveEvent();

    void _AddEvent()
    {
    }
    void _RemoveEvent()
    {
    }

}
