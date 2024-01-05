using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScene : Scene
{

    public override void _OnEnter()
    {
        Debug.Log("Main_onEnter");
        ActiveScene(SceneName.Game_1_Scene);
    }

    public override void _OnExite()
    {
        Debug.Log("Main_onExit");
    }


    





}
