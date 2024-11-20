using UnityEngine;
using UnityEngine.UI;

public class ValueGauge : Widget
{
    [SerializeField] private Image valueBarImage;

    public void UpdateValue(float newValue, float newMaxValue)
    {
        if (newMaxValue == 0)
            return;

        valueBarImage.fillAmount = newValue / newMaxValue;
    }
}
