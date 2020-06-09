using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePauseState : IState
{
    private BattleSM _stateMachine = null;
    private Controls _input = null;

    public BattlePauseState(BattleSM stateMachine, Controls input)
    {
        _stateMachine = stateMachine;
        _input = input;
    }

    public void Enter()
    {
        Time.timeScale = 0;
        _input.Combat.Pause.performed += ctx => HandlePause();
    }

    public void Exit()
    {
        Time.timeScale = 1;
        _input.Combat.Pause.performed -= ctx => HandlePause();
    }

    public void Tick()
    {
        
    }

    void HandlePause()
    {
        _stateMachine.ChangeStateToPrevious();
    }
}
