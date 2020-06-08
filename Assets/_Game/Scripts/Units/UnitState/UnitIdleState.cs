using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitIdleState : IState
{
    UnitSM _stateMachine;

    public UnitIdleState(UnitSM stateMachine)
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
