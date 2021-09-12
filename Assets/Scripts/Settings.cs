using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    List<string> resolution;
    public Dropdown dropdown;
    Resolution[] rsl;

    public AudioMixer am;
    private bool isFullScreen = false;

    private void Awake()
    {
        resolution = new List<string>();
        rsl = Screen.resolutions;
        foreach (var i in rsl)
        {
            resolution.Add(i.width + "x" + i.height);
        }

        dropdown.ClearOptions();
        dropdown.AddOptions(resolution);
    }

    public void Resolutions(int r)
    {
        Screen.SetResolution(rsl[r].width, rsl[r].height, isFullScreen);
    }

    public void FullScreenToggle()
    {
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
    }

    public void AudioVolme(float sliderValue)
    {
        am.SetFloat("masterVolume", sliderValue);
    }

    public void Quality(int q)
    {
        QualitySettings.SetQualityLevel(q);
    }

}
