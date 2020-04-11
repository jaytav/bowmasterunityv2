using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class UpdateHealthEvent : UnityEvent<int, int> {}

public class Health : MonoBehaviour {
    public int maxHealth = 3;
    public int currentHealth = 3;
    public UpdateHealthEvent updateHealthEvent;

    void Start() {
        updateHealthEvent.Invoke(maxHealth, currentHealth);
    }

    // GameObjects with Health get destroyed when <= 0
    public void TakeDamage(int damage) {
        currentHealth -= damage;

        if (currentHealth <= 0) {
            Destroy(gameObject);
        }

        updateHealthEvent.Invoke(maxHealth, currentHealth);
    }

    public void Heal(int healAmount) {
        currentHealth += healAmount;

        // prevents overheal
        if (currentHealth > maxHealth) {
            currentHealth = maxHealth;
            return;
        }

        updateHealthEvent.Invoke(maxHealth, currentHealth);
    }
}
