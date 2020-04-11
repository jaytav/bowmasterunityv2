using UnityEngine;

// Can only focus 1 Interactable at a time
public class Interactor : MonoBehaviour {
    Interactable interactable;

    void Update() {
        if (this.interactable != null && Input.GetKeyDown(KeyCode.E)) {
            this.interactable.GetInteractedWith(this);
            this.interactable = null;
        }
    }

    void OnTriggerStay2D(Collider2D collider) {
        Interactable interactable = collider.gameObject.GetComponent<Interactable>();

        if (this.interactable == null && interactable != null) {
            this.interactable = interactable;
            interactable.Highlight();
        }
    }

    void OnTriggerExit2D(Collider2D collider) {
        Interactable interactable = collider.gameObject.GetComponent<Interactable>();

        if (this.interactable != null && interactable != null) {
            this.interactable = null;
            interactable.Unhighlight();
        }
    }
}
