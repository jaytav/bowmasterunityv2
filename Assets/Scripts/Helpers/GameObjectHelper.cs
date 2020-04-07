using UnityEngine;

public class GameObjectHelper {
    public static bool HasLayer(GameObject go, string value) {
        if (go.layer == LayerMask.NameToLayer(value)) {
            return true;
        }
        return false;
    }

    public static bool HasTag(GameObject go, string value) {
        if (go.tag == value) {
            return true;
        }
        return false;
    }
}