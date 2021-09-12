using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyVelosity : MonoBehaviour
{
    private Camera camera;
    public float offset = 0;

    void Start()
    {
        camera = Camera.main;
    }

    void Update()
    {
        Vector2 screenMousePosition = Input.mousePosition;
        Vector2 worldMousePosition = camera.ScreenToWorldPoint(screenMousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(worldMousePosition.y, worldMousePosition.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offset);
    }

}
