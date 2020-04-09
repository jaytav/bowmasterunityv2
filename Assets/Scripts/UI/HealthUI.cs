using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour {
    Image health;

    void Awake() {
        health = GetComponent<Image>();
    }

    public void ActionUpdateHealth(int max, int current) {
        float healthPercentage = (float) current / max;
        health.fillAmount = healthPercentage;
    }
}
