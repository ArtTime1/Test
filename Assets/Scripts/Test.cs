using HutongGames.PlayMaker;
using HutongGames.PlayMaker.Actions;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;

public class Test : MonoBehaviour
{
    public PlayMakerFSM fsm;
    public PlayState state;
    public FsmTemplate fsmTemplate;
    public FsmString _fsmName;
    void Start()
    {
        fsm.SetState("Start");

        
        Debug.Log(fsm.ActiveStateName);
        Debug.Log(_fsmName);
        _fsmName = "Start";

        
    }

    
    void Update()
    {
        
    }

    public enum State
    {
        Start,
    }
}
