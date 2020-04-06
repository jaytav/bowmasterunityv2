using UnityEngine;

public class MathHelper {
    // Returns rotation between 2 Vectors
    public static Quaternion RotateFromTo(Vector2 from, Vector2 to) {
        Vector3 rotation = new Vector3();

        rotation.z = Mathf.Atan2(
            to.y - from.y,
            to.x - from.x
        );

        return Quaternion.Euler(rotation *  Mathf.Rad2Deg);
    }
}