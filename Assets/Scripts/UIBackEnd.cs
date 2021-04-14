using UnityEngine;
using UnityEngine.Audio;

public class UIBackEnd : MonoBehaviour
{
    public AudioMixer Audio;
    
    //Setting exposed Paramtes via Slider
    public void SetVolume(float volume)
    {
        Audio.SetFloat("Master", volume);
        PlayerPrefs.SetFloat("Master", volume);
    }
    
    public float GetVolume()
    {
        return PlayerPrefs.GetFloat("Master", -50);
    }

    public void SetSFX(float volume)
    {
        Audio.SetFloat("SFX", volume);
        PlayerPrefs.SetFloat("SFX", volume);
    }

    public float GetSFX()
    {
        return PlayerPrefs.GetFloat("SFX", -50);
    }

    public void SetMusic(float volume)
    {
        Audio.SetFloat("Music", volume);
        PlayerPrefs.SetFloat("Music", volume);
    }

    public float GetMusic()
    {
        return PlayerPrefs.GetFloat("Music", -50);
    }

    //Setting Graphics Quality via Dropdown 
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
