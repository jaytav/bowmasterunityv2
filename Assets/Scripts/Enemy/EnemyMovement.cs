using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public float speed = 20;
    public Vector2 direction = new Vector2();

    bool stopMoving = false;
    Vector3 minVelocity = new Vector3(-1, 0, 0);
    Vector3 maxVelocity = new Vector3(1, 0, 0);
    Rigidbody2D rb;
    Damage dmg;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        dmg = GetComponent<Damage>();
    }

    void FixedUpdate() {
        if (stopMoving) {
            return;
        }

        rb.AddForce(direction * speed);

        // Limit velocity using minVelocty/maxVelocity
        if (rb.velocity.x > maxVelocity.x) {
            maxVelocity.y = rb.velocity.y;
            rb.velocity = maxVelocity;
        } else if (rb.velocity.x <  minVelocity.x) {
            minVelocity.y = rb.velocity.y;
            rb.velocity = minVelocity;
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        Health health = collision.gameObject.GetComponent<Health>();
        if (health != null) {
            health.TakeDamage(dmg.DoDamage());
        }
    }

    public void ActionInRange() {
        stopMoving = true;
    }

    public void ActionOutOfRange() {
        stopMoving = false;
    }
}
