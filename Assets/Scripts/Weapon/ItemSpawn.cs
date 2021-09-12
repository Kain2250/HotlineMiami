using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    public float Drag = 0.1f;
    
    void Start()
    {
        Drop();
    }

    private void FixedUpdate()
    {
        Rigidbody2D _rb = GetComponent<Rigidbody2D>();
        
        if (_rb.velocity.y > 0.1f)
        {
            _rb.velocity -= new Vector2(0, Drag);
        }
        else if (_rb.velocity.y < -0.1f)
        {
            _rb.velocity += new Vector2(0, Drag);
        }
        else
        {
            _rb.velocity = new Vector2(_rb.velocity.x, 0);
        }
        
        if (_rb.velocity.x > 0.1f)
        {
            _rb.velocity -= new Vector2(Drag, 0);
        }
        else if (_rb.velocity.x < -0.1f)
        {
            _rb.velocity += new Vector2(Drag, 0);
        }
        else
        {
            _rb.velocity = new Vector2(0, _rb.velocity.y);
        }
    }

    public void Drop()
    {
        GetComponent<Rigidbody2D>().AddForce(-transform.up * 5.0f, ForceMode2D.Impulse);
    }
}
