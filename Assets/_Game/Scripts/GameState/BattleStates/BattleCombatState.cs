using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCombatState : IState
{
    BattleSM _stateMachine;

    public BattleCombatState(BattleSM stateMachine)
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
