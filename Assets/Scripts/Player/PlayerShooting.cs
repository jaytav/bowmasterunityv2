using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class EquipArrowEvent : UnityEvent<ItemArrowInteractable> {}

public class PlayerShooting : MonoBehaviour {
    public GameObject mainArrow;
    public GameObject secondaryArrow;
    public EquipArrowEvent equipArrowEvent;

    Vector2 mousePosInWorld = new Vector2();

    void Update() {        
        if (Input.GetButtonDown("Fire1") && mainArrow != null) {
            Shoot(mainArrow);
        } else if (Input.GetButtonDown("Fire2") && secondaryArrow != null) {
            Shoot(secondaryArrow);
        }
    }

    void Shoot(GameObject arrow) {
        mousePosInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Instantiate(arrow, transform.position, MathHelper.RotateFromTo(transform.position, mousePosInWorld));
    }

    public void EquipArrowEvent(ItemArrowInteractable interactable) {
        equipArrowEvent.Invoke(interactable);
    }
}
