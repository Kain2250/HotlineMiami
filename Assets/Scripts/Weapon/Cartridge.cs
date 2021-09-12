using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Cartridge : MonoBehaviour
{
    public float Speed = 0.3f;
    
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rb.transform.position = _rb.transform.position + _rb.transform.right * Speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }
}
