using UnityEngine;
using UnityEngine.Audio;

public class UIBackEnd : MonoBehaviour
{
    public AudioMixer Audio;    
    public void SetVolume(float volume)
    {
        Audio.SetFloat("Master", volume);
    }

    public void SetSFX(float volume)
    {
        Audio.SetFloat("SFX", volume);
    }

    public void SetMusic(float volume)
    {
        Audio.SetFloat("Music", volume);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
