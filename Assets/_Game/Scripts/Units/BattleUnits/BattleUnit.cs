using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleUnit : MonoBehaviour
{
    Transform _spawnPosition;
    public string Name { get; private set; }

    // faking constructor on a MonoBehaviour
    public void Initialize(BattleUnitData data, Transform spawnPosition)
    {
        _spawnPosition = spawnPosition;
        Name = data.Name;
    }
}
