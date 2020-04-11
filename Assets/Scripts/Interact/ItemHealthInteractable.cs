using UnityEngine;

public class ItemHealthInteractable : Interactable {
    public int healthAmount = 1;

    public override void GetInteractedWith(Interactor interactor) {
        Health health = interactor.gameObject.GetComponentInParent<Health>();
        
        if (health != null && health.currentHealth < health.maxHealth) {
            health.Heal(healthAmount);
            Destroy(transform.parent.gameObject);
        }
    }
}
