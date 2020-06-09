using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(ActionGauge))]
public class ActionGaugeView : MonoBehaviour
{
    [SerializeField] Vector3 _displayOffset = new Vector3(0, 0, 0); // adjusts after runtime
    [SerializeField] Image _fillImgView = null;

    [SerializeField] Color _fillingColor = Color.yellow;
    [SerializeField] Color _fullColor = Color.green;

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
        _actionGauge.OnGaugeEmptied += HandleGaugeEmptied;
    }

    private void OnDisable()
    {
        _actionGauge.OnGaugeFilled -= HandleGaugeFilled;
        _actionGauge.OnGaugeChanged -= HandleGaugeChanged;
        _actionGauge.OnGaugeEmptied -= HandleGaugeEmptied;
    }

    void HandleGaugeFilled()
    {
        _fillImgView.color = _fullColor;
    }

    void HandleGaugeChanged(float currentValue)
    {
        // fill amount is 1 max, so use normalized value (0 to 1 converted)
        _fillImgView.fillAmount = _actionGauge.CurrentValueNormalized;
        _fillImgView.color = _fillingColor;
    }

    void HandleGaugeEmptied()
    {
        _fillImgView.color = _fillingColor;
    }
}
