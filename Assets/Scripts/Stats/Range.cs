using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Range : MonoBehaviour {
    public float range;
    public UnityEvent inRangeEvent;
    public UnityEvent outOfRangeEvent;
    CircleCollider2D rangeCollider;

    void Start() {
        rangeCollider = GetComponent<CircleCollider2D>();
        rangeCollider.radius = range;
    }

    void OnTriggerEnter2D(Collider2D collider) {
        if (!GameObjectHelper.HasTag(collider.gameObject, "Player") || !GameObjectHelper.HasLayer(collider.gameObject, "Player")) {
            return;
        }
        inRangeEvent.Invoke();
    }

    void OnTriggerExit2D(Collider2D collider) {
        if (!GameObjectHelper.HasTag(collider.gameObject, "Player") || !GameObjectHelper.HasLayer(collider.gameObject, "Player")) {
            return;
        }
        outOfRangeEvent.Invoke();
    }
}
