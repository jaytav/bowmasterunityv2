using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFloorWallCheck : MonoBehaviour {
    EnemyMovement movement;
    BoxCollider2D floorWallCheck;

    void Start() {
        movement = GetComponentInParent<EnemyMovement>();         
        floorWallCheck = GetComponent<BoxCollider2D>();
    }

    void OnTriggerEnter2D(Collider2D collider) {
        if (!GameObjectHelper.HasTag(collider.gameObject, "Wall")) {
            return;
        }
        ChangeDirection();
    }

    void OnTriggerExit2D(Collider2D collider) {
        if (!GameObjectHelper.HasTag(collider.gameObject, "Floor")) {
            return;
        }
        ChangeDirection();
    }

    void ChangeDirection() {
        movement.direction.x *= -1;
        floorWallCheck.offset *= -1;
    }
}
