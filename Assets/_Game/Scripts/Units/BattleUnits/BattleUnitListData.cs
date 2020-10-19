using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewBattleUnitListData", menuName = "Battle/UnitList")]
public class BattleUnitListData : ScriptableObject
{
    [SerializeField] List<BattleUnitData> _unitList;
    public List<BattleUnitData> UnitList => _unitList;
}
