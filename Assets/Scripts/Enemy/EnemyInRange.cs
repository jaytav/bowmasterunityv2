using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyInRange : MonoBehaviour {
    Image inRangeImage;

    void Start() {
        inRangeImage = GetComponent<Image>();
    }

    public void ActionInRange() {
        inRangeImage.enabled = true;
    }

    public void ActionOutOfRange() {
        inRangeImage.enabled = false;
    }
}
