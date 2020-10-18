using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitActionIdleState : IState
{
    UnitActionSM _stateMachine = null;
    ActionGauge _actionGauge = null;

    public UnitActionIdleState(UnitActionSM stateMachine, ActionGauge actionGauge)
    {
        _stateMachine = stateMachine;
        _actionGauge = actionGauge;
    }

    public void Enter()
    {
        Debug.Log("UnitState: Idle");
        _actionGauge.OnGaugeFilled += HandleGaugeFilled;
    }

    public void Exit()
    {
        _actionGauge.OnGaugeFilled -= HandleGaugeFilled;
    }

    public void Tick()
    {

    }

    void HandleGaugeFilled()
    {
        _stateMachine.ChangeState(_stateMachine.ReadyState);
    }
}
