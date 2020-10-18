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
    public float CurrentValue => _currentValue;
    // this is our current value from 0-1 scale
    public float CurrentValueNormalized
    {
        get
        {
            return (1 / MaxValue) * _currentValue;
        }
    }

    public float MaxValue { get; private set; } = 100;
    public float StartingValue { get; private set; } = 50;

    public float FillSpeed { get; private set; } = 10;
    public bool IsActive { get; private set; } = true;

    public void Init(float maxValue, float fillSpeed, float startingValue)
    {
        MaxValue = maxValue;
        FillSpeed = fillSpeed;
        StartingValue = startingValue;
    }

    private void Start()
    {
        SetGauge(StartingValue);
    }

    void Update()
    {
        if(IsActive && CurrentValue < MaxValue)
        {
            IncreaseGauge(FillSpeed * Time.deltaTime);
        }
    }

    public void IncreaseGauge(float amount)
    {
        float newValue = CurrentValue + amount;
        SetGauge(newValue);
    }

    public void DecreaseGauge(float amount)
    {
        float newValue = CurrentValue - amount;
        SetGauge(newValue);
    }

    public void SetGauge(float amount)
    {
        amount = Mathf.Clamp(amount, 0, MaxValue);
        _currentValue = amount;

        OnGaugeChanged.Invoke(CurrentValue);
        // check other event conditions
        if(CurrentValue == 0)
        {
            OnGaugeEmptied.Invoke();
        }
        else if(CurrentValue == MaxValue)
        {
            OnGaugeFilled.Invoke();
        }
    }
}
