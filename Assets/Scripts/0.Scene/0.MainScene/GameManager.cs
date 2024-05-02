using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : IScene
{

    public List<IScene.SceneName> SceneList;    
    public IScene.SceneName EntryScene;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        // 게임의 로그인 단계
        PlayerInfo.Instance.Name = "Player";
        //
        // UI 카메라 생성
        // 
        // 게임의 씬 전환을 메니저가 담당하자
        //
    }
    private void Start()
    {
        // 게임의 첫화면
        // 이부분에 게임 입장 로고를 띄어줘도 될거같다.        
        // EntryScene 으로 이동
    }


    protected override void _OnEnter() => _AddEvent();
    protected override void _OnExite() => _RemoveEvent();

    void _AddEvent()
    { 
        

    }
    void _RemoveEvent()
    { 
        

    }





}
