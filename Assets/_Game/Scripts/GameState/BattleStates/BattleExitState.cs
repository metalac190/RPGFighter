using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleExitState : IState
{
    BattleSM _stateMachine = null;
    Controls _input = null;

    public BattleExitState(BattleSM stateMachine, Controls input)
    {
        _input = input;
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
