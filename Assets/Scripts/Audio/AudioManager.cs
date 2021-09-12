using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AudioManager : MonoBehaviour
{
    public AudioSource[] AudiosFone;
    public AudioSource AudioSaccess;
    public AudioSource AudioFail;

    private void Start()
    {
        LevelStart();
        Invoke("LevelSuccess", 3.0f);
        Invoke("LevelFail", 6.0f);
    }

    public void LevelStart()
    {
        AudiosFone[Random.Range(0, AudiosFone.Length)].Play();
    }

    public void LevelSuccess()
    {
        AudioSaccess.Play();
    }

    public void LevelFail()
    {
        AudioFail.Play();
    }
}
