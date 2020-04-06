using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed = 25;
    public float jumpPower = 125;

    Vector3 movement = new Vector3(0, 0, 0);
    Vector3 minVelocity = new Vector3(-1, 0, 0);
    Vector3 maxVelocity = new Vector3(1, 0, 0);
    Rigidbody2D rb;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        movement.x = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump")) {
            rb.AddForce(Vector3.up * jumpPower);
        }
    }

    void FixedUpdate() {
        if (movement.x == 0.0f) {
            return;
        }

        rb.AddForce(movement * speed);

        // Limit velocity using minVelocty/maxVelocity
        if (rb.velocity.x > maxVelocity.x) {
            maxVelocity.y = rb.velocity.y;
            rb.velocity = maxVelocity;
        } else if (rb.velocity.x <  minVelocity.x) {
            minVelocity.y = rb.velocity.y;
            rb.velocity = minVelocity;
        }
    }
}
