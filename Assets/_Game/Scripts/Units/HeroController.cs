using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    UnitActionSM _unitSM = null;

    private void Awake()
    {
        _unitSM = GetComponent<UnitActionSM>();
    }
}
