using UnityEngine;
using UnityEngine.UI;

public class MusicSlider : MonoBehaviour
{
    public UIBackEnd Value;
    private Slider slider;
    private void Start()
    {
        slider = gameObject.GetComponent<Slider>();
        slider.value = Value.GetMusic();
    }
}
