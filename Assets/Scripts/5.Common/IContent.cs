using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IContent : MonoBehaviour
{
    // Dialog Load


    private void OnEnable() => _OnEnter();
    private void OnDisable() => _OnExite();

    protected virtual void _OnEnter()
    { }
    protected virtual void _OnExite()
    { }



}
