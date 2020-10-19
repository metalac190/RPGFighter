using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
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
        _input.Combat.Attack01.performed += ctx => OnAttack01Performed();
        _input.Combat.Attack02.performed += ctx => OnAttack02Performed();
        _input.Combat.Attack03.performed += ctx => OnAttack03Performed();
        _input.Combat.Attack04.performed += ctx => OnAttack04Performed();

        _input.Combat.Pause.performed += ctx => OnPausePerformed();

        _input.Combat.MoveSelectUp.performed += ctx => OnMoveSelectUpPerformed();
        _input.Combat.MoveSelectUp.performed += ctx => OnMoveSelectDownPerformed();
        _input.Combat.MoveSelectUp.performed += ctx => OnMoveSelectLeftPerformed();
        _input.Combat.MoveSelectUp.performed += ctx => OnMoveSelectRightPerformed();
    }

    public void Exit()
    {
        _input.Combat.Attack01.performed -= ctx => OnAttack01Performed();
        _input.Combat.Attack02.performed -= ctx => OnAttack02Performed();
        _input.Combat.Attack03.performed -= ctx => OnAttack03Performed();
        _input.Combat.Attack04.performed -= ctx => OnAttack04Performed();

        _input.Combat.Pause.performed -= ctx => OnPausePerformed();

        _input.Combat.MoveSelectUp.performed -= ctx => OnMoveSelectUpPerformed();
        _input.Combat.MoveSelectUp.performed -= ctx => OnMoveSelectDownPerformed();
        _input.Combat.MoveSelectUp.performed -= ctx => OnMoveSelectLeftPerformed();
        _input.Combat.MoveSelectUp.performed -= ctx => OnMoveSelectRightPerformed();
    }

    public void Tick()
    {
        
    }

    void OnAttack01Performed()
    {
        Debug.Log("Hero 01 perform attack");
    }

    void OnAttack02Performed()
    {
        Debug.Log("Hero 02 perform attack");
    }

    void OnAttack03Performed()
    {
        Debug.Log("Hero 03 perform attack");
    }

    void OnAttack04Performed()
    {
        Debug.Log("Hero 04 perform attack");
    }

    void OnPausePerformed()
    {
        _stateMachine.ChangeState(_stateMachine.BattlePauseState);
    }

    void OnMoveSelectUpPerformed()
    {
        Debug.Log("Move Cursor Up");
    }

    void OnMoveSelectDownPerformed()
    {
        Debug.Log("Move Cursor Down");
    }

    void OnMoveSelectLeftPerformed()
    {
        Debug.Log("Move Cursor Left");
    }

    void OnMoveSelectRightPerformed()
    {
        Debug.Log("Move Cursor Right");
    }
}
