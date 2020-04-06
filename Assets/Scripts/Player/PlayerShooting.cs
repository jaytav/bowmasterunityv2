using UnityEngine;

public class PlayerShooting : MonoBehaviour {
    public GameObject arrow;

    Vector2 mousePosInWorld = new Vector2();

    void Update() {        
        if (Input.GetButtonDown("Fire1")) {
            mousePosInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(arrow, transform.position, MathHelper.RotateFromTo(transform.position, mousePosInWorld));
        }
    }
}
