using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAudio : MonoBehaviour
{
    public AudioSource[] AudiosDie;
    public AudioSource AudioSelectedWeapon;

    public void Die()
    {
        AudiosDie[Random.Range(0, AudiosDie.Length)].Play();
    }
    
    public void SelectedWeapon()
    {
        AudioSelectedWeapon.Play();
    }
}
