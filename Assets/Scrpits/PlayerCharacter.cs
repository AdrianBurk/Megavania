using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour 
{
    [SerializeField]
    private float accelerationForce = 100;

    [SerializeField]
    private float maxSpeed = 25;

    [SerializeField]
    private float jumpForce = 3000;

    [SerializeField]
    private Rigidbody2D rb2d;

    Animator animator;

    private float horizontalInput;

    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    public float maxDashTime = 1.0f;


    // Update is called once per frame
    void Update()
    {
        // Gets player input
        horizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump"))
        {
            rb2d.AddForce(Vector2.up * jumpForce);
            
        }
	}

    private void FixedUpdate()
    {
        Move();

    }

    private void Move()
    {
        rb2d.AddForce(Vector2.right * horizontalInput * accelerationForce);
        Vector2 clampedVelocity = rb2d.velocity;
        clampedVelocity.x = Mathf.Clamp(rb2d.velocity.x, -maxSpeed, maxSpeed);
        rb2d.velocity = clampedVelocity;
    }
}
