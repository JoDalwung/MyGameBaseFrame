using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDialog : MonoBehaviour
{
    public enum DialogName
    { 
        LobbyDialog,    
    }

    // 공용으로 쓸만한 기능 : fade in out



    private void OnEnable() => _OnEnter();
    private void OnDisable() => _OnExite();

    protected virtual void _OnEnter()
    { }
    protected virtual void _OnExite()
    { }



}
