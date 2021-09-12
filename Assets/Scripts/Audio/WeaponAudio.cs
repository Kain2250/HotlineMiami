using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAudio : MonoBehaviour
{
    private AudioSource _weaponAudio;

    private void Start()
    {
        _weaponAudio = GetComponent<AudioSource>();
    }

    public void Attack()
    {
        _weaponAudio.Play();
    }
}
