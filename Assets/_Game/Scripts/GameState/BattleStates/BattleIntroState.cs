﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleIntroState : IState
{
    BattleSM _stateMachine = null;
    BattleUnitSpawner _spawner = null;

    Coroutine _introRoutine = null;

    float _introDelay = 1.5f;

    public BattleIntroState(BattleSM stateMachine, BattleUnitSpawner spawner)
    {
        _stateMachine = stateMachine;
        _spawner = spawner;
    }

    public void Enter()
    {
        Debug.Log("STATE: Battle Intro");
        Timer.DelayActionRetriggerable
            (_stateMachine, ExitIntro, _introDelay, _introRoutine);
        //_spawner.SpawnHeroes();
        //_spawner.SpawnEnemies();
    }

    public void Exit()
    {
        
    }

    public void Tick()
    {
        
    }

    void ExitIntro()
    {
        _stateMachine.ChangeState(_stateMachine.BattleCombatState);
    }
}
