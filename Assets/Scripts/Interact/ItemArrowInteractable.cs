using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemArrowInteractable : Interactable {
    public GameObject arrow;

    public override void GetInteractedWith(Interactor interactor) {
        PlayerShooting playerShooting = interactor.gameObject.GetComponentInParent<PlayerShooting>();

        if (playerShooting != null) {
            playerShooting.EquipArrowEvent(this);
        }
    }
}
