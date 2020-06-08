using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ActionGauge : MonoBehaviour
{
    public event Action OnGaugeFilled = delegate { };
    public event Action<float> OnGaugeChanged = delegate { };
    public event Action OnGaugeEmptied = delegate { };

    float _currentValue = 0;
    public float CurrentValue {
        get => _currentValue;
        private set
        {
            value = Mathf.Clamp(value, 0, MaxValue);
            _currentValue = value;
        }
    }

    public float MaxValue { get; private set; } = 100;
    public float StartingValue { get; private set; } = 50;

    public float FillSpeed { get; private set; } = 10;
    public bool IsActive { get; private set; } = true;

    private void Awake()
    {
        CurrentValue = StartingValue;
    }

    void Update()
    {
        if(IsActive && CurrentValue < MaxValue)
        {
            IncreaseGauge(FillSpeed * Time.deltaTime);
        }
    }

    private void IncreaseGauge(float amount)
    {
        CurrentValue += amount;
        OnGaugeChanged.Invoke(CurrentValue);

        // check if we're just now filled for the first time
        if (CurrentValue >= MaxValue)
        {
            OnGaugeFilled.Invoke();
        }
    }

    private void DecreaseGauge(float amount)
    {
        CurrentValue -= amount;
        OnGaugeChanged.Invoke(CurrentValue);

        // check to see if we just emptied for the first time
        if(CurrentValue == 0)
        {
            OnGaugeEmptied.Invoke();
        }
    }

    private void EmptyGauge()
    {
        CurrentValue = 0;
        OnGaugeChanged.Invoke(CurrentValue);
        OnGaugeEmptied.Invoke();
    }
}
