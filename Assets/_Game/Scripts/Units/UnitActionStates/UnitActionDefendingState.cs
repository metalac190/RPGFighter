using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitActionDefendingState : IState
{
    UnitActionSM _stateMachine;

    public UnitActionDefendingState(UnitActionSM stateMachine)
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
