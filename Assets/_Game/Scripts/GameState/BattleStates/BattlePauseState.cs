using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePauseState : IState
{
    BattleSM _stateMachine;

    public BattlePauseState(BattleSM stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void Enter()
    {
        throw new System.NotImplementedException();
    }

    public void Exit()
    {
        throw new System.NotImplementedException();
    }

    public void Tick()
    {
        throw new System.NotImplementedException();
    }
}
