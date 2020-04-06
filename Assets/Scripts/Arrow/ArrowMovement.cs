using UnityEngine;

public class ArrowMovement : MonoBehaviour {

    public float speed = 25;

    Rigidbody2D rb;
    Vector3 arrowDirection = new Vector3();
    Vector3 arrowLastPosition = new Vector3();

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        arrowLastPosition = transform.position;
        arrowDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        rb.velocity = arrowDirection.normalized * speed;
    }

    void Update() {
        // Rotate in travelling direction
        if (arrowLastPosition != transform.position) {
            transform.rotation = MathHelper.RotateFromTo(arrowLastPosition, transform.position);
            arrowLastPosition = transform.position;
        }
    }

    // Destroy Arrow on any collision (for now)
    void OnTriggerEnter2D(Collider2D c) {
        Destroy(gameObject);
    }
}
