using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewBattleUnitData", menuName = "Battle/Unit")]
public class BattleUnitData : ScriptableObject
{
    [SerializeField] string _name = "...";
    public string Name => _name;
}
