using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public Animator animator;
	private Vector2 moveVelocity;
	private Rigidbody2D rigidbody;
	private CharacterAudioProcess audioProcess;
	public GameObject weapon;

	public float speed;
	private bool isAlive = true;


	void Start()
	{
		rigidbody = GetComponent<Rigidbody2D>();
		audioProcess = GetComponent<CharacterAudioProcess>();
	}

	void Update()
	{
		if (isAlive)
		{
			Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
			if (Input.GetKeyDown(KeyCode.W))
			{
				rigidbody.velocity = new Vector2(0, speed);
			}
			else if (Input.GetKeyDown(KeyCode.S))
			{
				rigidbody.velocity = new Vector2(0, -speed);
			}
			else if (Input.GetKeyDown(KeyCode.A))
			{
				rigidbody.velocity = new Vector2(speed, 0);
			}
			else if (Input.GetKeyDown(KeyCode.D))
			{
				rigidbody.velocity = new Vector2(-speed, 0);
			}
			moveVelocity = moveInput.normalized * speed;
            if (moveVelocity.x != 0 || moveVelocity.y != 0) {
				animator.SetBool("isRun", true);
			} else {
				animator.SetBool("isRun", false);
			}
		}
	}


	private void FixedUpdate()
	{
		rigidbody.MovePosition(rigidbody.position + moveVelocity * Time.fixedDeltaTime);
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.transform.tag == "ammo")
		{
			audioProcess.Die();
            isAlive = false;
            
			Invoke("Dest", 1f);
		}
		if (other.transform.tag == "weapon" && Input.GetKey(KeyCode.E))
		{
			audioProcess.SelectedWeapon();
			weapon = other.gameObject;
		}

	}

	private void Dest()
	{
		Destroy(gameObject);
	}

}
