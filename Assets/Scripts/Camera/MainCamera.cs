using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour {
    public GameObject focus;
    public float followSpeed = 0.2f;
    
    Vector3 position;
    Vector3 offset = new Vector3(0, 0, -10);

    void FixedUpdate() {
        if (focus != null) {
            transform.position = Vector3.Lerp(transform.position, focus.transform.position + offset, followSpeed);
        }
    }
}
