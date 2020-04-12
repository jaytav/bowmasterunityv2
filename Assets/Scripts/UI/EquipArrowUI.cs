using UnityEngine;
using UnityEngine.UI;

public class EquipArrowUI : MonoBehaviour {
    Canvas canvas;
    Image equipArrowImage;
    PlayerShooting playerShooting;
    ItemArrowInteractable interactable;
    
    public GameObject itemArrowBase;

    public Button equipMainArrowButton;
    public Button equipSecondaryArrowButton;

    // PlayerArrowsUI
    public Image mainArrowImage;
    public Image secondaryArrowImage;

    void Start() {
        canvas = GetComponent<Canvas>();
        equipArrowImage = transform.Find("EquipArrowImage").GetComponent<Image>();
        playerShooting = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerShooting>();
    }

    public void EquipArrowPrompt(ItemArrowInteractable interactable) {
        // focus
        equipMainArrowButton.interactable = true;
        equipSecondaryArrowButton.interactable = true;

        equipArrowImage.sprite = interactable.transform.parent.GetComponent<SpriteRenderer>().sprite;
        this.interactable = interactable;
        canvas.enabled = true;
    }

    public void EquipMain() {
        if (playerShooting.mainArrow != null) {
            dropArrow(playerShooting.mainArrow);
        }
        mainArrowImage.sprite = equipArrowImage.sprite;
        playerShooting.mainArrow = interactable.arrow;
        mainArrowImage.enabled = true;
        hide();
    }

    public void EquipSecondary() {
        if (playerShooting.secondaryArrow != null) {
            dropArrow(playerShooting.secondaryArrow);
        }
        secondaryArrowImage.sprite = equipArrowImage.sprite;
        playerShooting.secondaryArrow = interactable.arrow;
        secondaryArrowImage.enabled = true;
        hide();
    }

    void hide() {
        // unfocus
        equipMainArrowButton.interactable = false;
        equipSecondaryArrowButton.interactable = false;

        canvas.enabled = false;
        equipArrowImage.sprite = null;
        Destroy(interactable.transform.parent.gameObject);
    }

    void dropArrow(GameObject arrow) {
        GameObject droppedArrow = Instantiate(itemArrowBase, playerShooting.transform.position, itemArrowBase.transform.rotation);
        droppedArrow.GetComponent<SpriteRenderer>().sprite = arrow.GetComponent<SpriteRenderer>().sprite;
        droppedArrow.GetComponentInChildren<ItemArrowInteractable>().arrow = arrow;
    }
}
