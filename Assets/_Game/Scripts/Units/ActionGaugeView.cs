using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(ActionGauge))]
public class ActionGaugeView : MonoBehaviour
{
    [SerializeField] Vector3 _displayOffset = new Vector3(0, 0, 0); // adjusts after runtime
    [SerializeField] Image _fillImgView = null;

    ActionGauge _actionGauge = null;

    private void Awake()
    {
        _actionGauge = GetComponent<ActionGauge>();

        transform.localPosition += _displayOffset;
    }

    private void OnEnable()
    {
        _actionGauge.OnGaugeFilled += HandleGaugeFilled;
        _actionGauge.OnGaugeChanged += HandleGaugeChanged;
    }

    private void OnDisable()
    {
        _actionGauge.OnGaugeFilled -= HandleGaugeFilled;
        _actionGauge.OnGaugeChanged -= HandleGaugeChanged;
    }

    void HandleGaugeFilled()
    {
        //TODO display visual here
    }

    void HandleGaugeChanged(float currentValue)
    {
        //TODO display current value
    }
}
