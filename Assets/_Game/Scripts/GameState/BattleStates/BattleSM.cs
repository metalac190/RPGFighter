using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSM : StateMachine
{
    // states
    public BattleIntroState BattleIntroState { get; private set; }
    public BattleCombatState BattleCombatState { get; private set; }
    public BattlePauseState BattlePauseState { get; private set; }
    public BattleMenuSelectState BattleMenuSelectState { get; private set; }
    public BattleAbilitySelectState BattleAbilitySelectState { get; private set; }

    private void Awake()
    {
        // setup state machines
        BattleIntroState = new BattleIntroState(this);
        BattleCombatState = new BattleCombatState(this);
        BattlePauseState = new BattlePauseState(this);
        BattleMenuSelectState = new BattleMenuSelectState(this);
        BattleAbilitySelectState = new BattleAbilitySelectState(this);
    }

    private void Start()
    {
        ChangeState(BattleIntroState);
    }
}
