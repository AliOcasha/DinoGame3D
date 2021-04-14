using UnityEngine;
using UnityEngine.UI;

public class MasterSlider : MonoBehaviour
{
    public UIBackEnd Value;
    private Slider slider;
    // Start is called before the first frame update
    private void Start()
    {
        slider = gameObject.GetComponent<Slider>();
        slider.value = Value.GetVolume();
    }
}
