using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitActionSM : StateMachine
{
    [SerializeField] ActionGauge _actionGauge = null;
    public ActionGauge ActionGauge => _actionGauge;

    public UnitActionIdleState UnitActionIdleState { get; private set; }
    public UnitActionAttackingState UnitActionAttackingState { get; private set; }
    public UnitActionPreparingState UnitActionPreparingState { get; private set; }
    public UnitActionDefendingState UnitActionDefendingState { get; private set; }
    public UnitActionReadyState UnitActionReadyState { get; private set; }
    public UnitActionCastingState UnitActionCastingState { get; private set; }
    public UnitActionKOState UnitActionKOState { get; private set; }

    private void Awake()
    {
        // set up states
        UnitActionIdleState = new UnitActionIdleState(this, ActionGauge);
        UnitActionAttackingState = new UnitActionAttackingState(this);
        UnitActionPreparingState = new UnitActionPreparingState(this);
        UnitActionDefendingState = new UnitActionDefendingState(this);
        UnitActionReadyState = new UnitActionReadyState(this);
        UnitActionCastingState = new UnitActionCastingState(this);
        UnitActionKOState = new UnitActionKOState(this);
    }

    private void Start()
    {
        ChangeState(UnitActionIdleState);
    }
}
