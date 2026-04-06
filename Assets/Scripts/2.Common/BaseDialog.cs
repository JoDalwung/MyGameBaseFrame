using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseDialog : MonoBehaviour
{
    // 공용으로 쓸만한 기능 : fade in out
    [SerializeField] private Transform _dialogRoot;
    public Transform DialogRoot => _dialogRoot;

    private void Awake() => _OnLoad();
    private void Start() => _OnLoadComplete();
    private void OnEnable() => _OnEnter();
    private void OnDisable() => _OnExit();

    protected virtual void _OnLoad() { }
    protected virtual void _OnLoadComplete() { }
    protected virtual void _OnEnter(){ }
    protected virtual void _OnExit(){ }



}
