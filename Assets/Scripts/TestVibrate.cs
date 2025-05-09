using UnityEngine;
using UnityEngine.UI;
using CandyCoded.HapticFeedback;

public class TestVibrate : MonoBehaviour
{
    public Button btnVibrateLight;
    public Button btnVibrateMedium;
    public Button btnVibrateHeavy;

    private void Start()
    {
        btnVibrateLight.onClick.AddListener(() =>
        {
            HapticFeedback.LightFeedback();
        });
        btnVibrateMedium.onClick.AddListener(() =>
        {
            HapticFeedback.MediumFeedback();
        });
        btnVibrateHeavy.onClick.AddListener(() =>
        {
            HapticFeedback.HeavyFeedback();
        });
    }
}
