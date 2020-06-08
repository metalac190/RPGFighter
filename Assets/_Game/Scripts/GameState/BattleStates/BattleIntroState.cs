using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleIntroState : IState
{
    BattleSM _stateMachine;

    public BattleIntroState(BattleSM stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void Enter()
    {
        Debug.Log("ENTER: Battle Intro");
    }

    public void Exit()
    {
        
    }

    public void Tick()
    {
        Debug.Log("EXIT: Battle Intro");
    }
}
