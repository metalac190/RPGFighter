using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSM : MonoBehaviour
{
    public UnitIdleState UnitIdleState { get; private set; }
    public UnitAttackingState UnitAttackingState { get; private set; }
    public UnitPreparingState UnitPreparingState { get; private set; }
    public UnitDefendingState UnitDefendingState { get; private set; }
    public UnitReadyState UnitReadyState { get; private set; }
    public UnitCastingState UnitCastingState { get; private set; }
    public UnitKOState UnitKOState { get; private set; }

    private void Awake()
    {
        // set up states
        
    }
}
