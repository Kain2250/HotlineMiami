using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAudioProcess : MonoBehaviour
{
    public WeaponAudio AudioPrefab;

    public void Attack()
    {
        AudioPrefab.Attack();
    }
}
