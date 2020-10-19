using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BattleSM : StateMachine
{
    [SerializeField] InputController _input = null;
    InputController Input => _input;

    [SerializeField] BattleUnitSpawner _spawner = null;
    BattleUnitSpawner Spawner => _spawner;

    public List<BattleUnit> HeroList { get; private set; }
    public List<BattleUnit> EnemyList { get; private set; }

    public BattleUnit SelectedEnemy { get; private set; }
    // states
    public BattleIntroState BattleIntroState { get; private set; }
    public BattleCombatState BattleCombatState { get; private set; }
    public BattlePauseState BattlePauseState { get; private set; }
    public BattleMenuSelectState BattleMenuSelectState { get; private set; }
    public BattleAbilitySelectState BattleAbilitySelectState { get; private set; }

    private void Awake()
    {
        // setup state machines
        BattleIntroState = new BattleIntroState(this, _spawner);
        BattleCombatState = new BattleCombatState(this, Input.Controls);
        BattlePauseState = new BattlePauseState(this, Input.Controls);
        BattleMenuSelectState = new BattleMenuSelectState(this);
        BattleAbilitySelectState = new BattleAbilitySelectState(this);
    }
}
