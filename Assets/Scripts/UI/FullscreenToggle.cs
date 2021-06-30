using UnityEngine;
using UnityEngine.UI;

public class FullscreenToggle : MonoBehaviour
{
    public UIBackEnd Value;

    private Toggle toggle;
    // Get current Fullscreen Settingss
    void Start()
    {
        toggle = gameObject.GetComponent<Toggle>();
        toggle.isOn = Value.GetFullscreen();
    }
}
