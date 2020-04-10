using UnityEngine;

public class Interactable : MonoBehaviour {
    SpriteRenderer sprite;

    void Start() {
        sprite = GetComponent<SpriteRenderer>();
    }

    public void Highlight() {
        sprite.enabled = true;
    }

    public void Unhighlight() {
        sprite.enabled = false;
    }

    // Destroy Interactable held GameObject 
    public void GetInteractedWith() {
        Destroy(transform.parent.gameObject);
    }
}
