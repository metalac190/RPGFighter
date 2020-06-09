using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitActionReadyState : IState
{
    UnitActionSM _stateMachine = null;

    public UnitActionReadyState(UnitActionSM stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void Enter()
    {
        
    }

    public void Exit()
    {
        
    }

    public void Tick()
    {
        
    }
}
