﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitActionAttackingState : IState
{
    UnitActionSM _stateMachine;

    public UnitActionAttackingState(UnitActionSM stateMachine)
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
