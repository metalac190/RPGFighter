using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCombatState : IState
{
    BattleSM _stateMachine = null;
    Controls _input = null;

    public BattleCombatState(BattleSM stateMachine, Controls input)
    {
        _stateMachine = stateMachine;
        _input = input;
    }

    public void Enter()
    {
        Debug.Log("STATE: Battle Combat");
        _input.Combat.Attack01.performed += ctx => HandleAttack01();
        _input.Combat.Attack02.performed += ctx => HandleAttack02();
        _input.Combat.Attack03.performed += ctx => HandleAttack03();
        _input.Combat.Attack04.performed += ctx => HandleAttack04();
        _input.Combat.Pause.performed += ctx => HandlePause();
    }

    public void Exit()
    {
        _input.Combat.Attack01.performed -= ctx => HandleAttack01();
        _input.Combat.Attack02.performed -= ctx => HandleAttack02();
        _input.Combat.Attack03.performed -= ctx => HandleAttack03();
        _input.Combat.Attack04.performed -= ctx => HandleAttack04();
        _input.Combat.Pause.performed -= ctx => HandlePause();
    }

    public void Tick()
    {
        
    }

    void HandleAttack01()
    {
        Debug.Log("Hero 01 perform attack");
    }

    void HandleAttack02()
    {
        Debug.Log("Hero 01 perform attack");
    }

    void HandleAttack03()
    {
        Debug.Log("Hero 01 perform attack");
    }

    void HandleAttack04()
    {
        Debug.Log("Hero 01 perform attack");
    }

    void HandlePause()
    {
        _stateMachine.ChangeState(_stateMachine.BattlePauseState);
    }
}
