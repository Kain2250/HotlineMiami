using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAudioProcess : MonoBehaviour
{
    public CharacterAudio AudioPrefab;

    public void Die()
    {
        AudioPrefab.Die();
    }

    public void SelectedWeapon()
    {
        AudioPrefab.SelectedWeapon();
    }
}
