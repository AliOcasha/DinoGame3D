using UnityEngine;
using UnityEngine.Audio;

public class UIBackEnd : MonoBehaviour
{
    public AudioMixer Audio;
    
    //Setting exposed Parameters via Slider
    // Getting current Parameter
    public void SetVolume(float volume)
    {
        Audio.SetFloat("Master", volume);
        PlayerPrefs.SetFloat("Master", volume);
    }
    
    public float GetVolume()
    {
        return PlayerPrefs.GetFloat("Master", -15);
    }

    public void SetSFX(float volume)
    {
        Audio.SetFloat("SFX", volume);
        PlayerPrefs.SetFloat("SFX", volume);
    }

    public float GetSFX()
    {
        return PlayerPrefs.GetFloat("SFX", -15);
    }

    public void SetMusic(float volume)
    {
        Audio.SetFloat("Music", volume);
        PlayerPrefs.SetFloat("Music", volume);
    }

    public float GetMusic()
    {
        return PlayerPrefs.GetFloat("Music", -15);
    }

    //Setting Graphics Quality via Dropdown 
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    //Setting Fullscreen
    public void SetFullscreen(bool isFullscreen)
    {
        int Fullscreen;
        if (isFullscreen)
        {
            Fullscreen = 1;
        }
        else
        {
            Fullscreen = 0;
        }
        Screen.fullScreen = isFullscreen;
        PlayerPrefs.SetInt("Fullscreen", Fullscreen);
    }
    // Getting Fullscreen Settings
    public bool GetFullscreen()
    {
        bool isFullscreen;
        if (PlayerPrefs.GetInt("Fullscreen",1) == 1)
        {
            isFullscreen = true;
        }
        else
        {
            isFullscreen = false;
        }
        return isFullscreen;
    }
}
