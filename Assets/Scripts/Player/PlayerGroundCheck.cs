using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundCheck : MonoBehaviour {
    PlayerMovement playerMovement;

    void Start() {
        playerMovement = GetComponentInParent<PlayerMovement>();
    }

    void OnTriggerEnter2D(Collider2D collider) {
        playerMovement.grounded = true;
    }

    void OnTriggerStay2D(Collider2D collider) {
        playerMovement.grounded = true;
    }

    void OnTriggerExit2D(Collider2D collider) {
        playerMovement.grounded = false;
    }
}
