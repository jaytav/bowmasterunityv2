using UnityEngine;

public class Health : MonoBehaviour {
    public int maxHealth = 3;
    public int currentHealth = 3;

    // GameObjects with Health get destroyed when <= 0
    public void TakeDamage(int damage) {
        currentHealth -= damage;

        if (currentHealth <= 0) {
            Destroy(gameObject);
        }
    }
}
