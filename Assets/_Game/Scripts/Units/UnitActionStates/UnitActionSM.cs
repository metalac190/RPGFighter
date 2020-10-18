using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitActionSM : StateMachine
{
    [SerializeField] ActionGauge _actionGauge = null;
    public ActionGauge ActionGauge => _actionGauge;

    public UnitActionIdleState IdleState { get; private set; }
    public UnitActionAttackingState AttackingState { get; private set; }
    public UnitActionPreparingState PreparingState { get; private set; }
    public UnitActionDefendingState DefendingState { get; private set; }
    public UnitActionReadyState ReadyState { get; private set; }
    public UnitActionKOState KOState { get; private set; }

    private void Awake()
    {
        // set up states
        IdleState = new UnitActionIdleState(this, ActionGauge);
        AttackingState = new UnitActionAttackingState(this);
        PreparingState = new UnitActionPreparingState(this);
        DefendingState = new UnitActionDefendingState(this);
        ReadyState = new UnitActionReadyState(this);
        KOState = new UnitActionKOState(this);
    }

    private void Start()
    {
        ChangeState(IdleState);
    }
}
