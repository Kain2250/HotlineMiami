using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{
    public float TimeLife = 0.05f;

    private void Start()
    {
        Invoke("Die", TimeLife);
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
