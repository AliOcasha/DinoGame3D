using UnityEngine;
using UnityEngine.UI;

public class SFXSlider : MonoBehaviour
{
    public UIBackEnd Value;
    private Slider slider;

    // Get Current SFXVolume Setting
    private void Start()
    {
        slider = gameObject.GetComponent<Slider>();
        slider.value = Value.GetSFX();
    }
}
