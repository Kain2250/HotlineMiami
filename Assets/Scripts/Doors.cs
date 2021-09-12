using UnityEngine;

public class Doors : MonoBehaviour
{
    private bool open;
    private bool enter;
    private Vector3 defaultPos;
    private Vector3 openPos;

    private void Start()
    {
        defaultPos = transform.localPosition;
        openPos = new Vector3(0, 0.87f, 0);
    }

    private void Update()
    {
        if (open && Input.GetKeyDown(KeyCode.E) && enter)
        {
            transform.Translate(openPos, Space.Self);
        }
        else if (Input.GetKeyDown(KeyCode.E) && enter)
        {
            transform.position = defaultPos;
        }
        if (Input.GetKeyDown(KeyCode.E) && enter)
        {
            open = !open;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enter = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enter = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            enter = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            enter = false;
        }
    }
}
