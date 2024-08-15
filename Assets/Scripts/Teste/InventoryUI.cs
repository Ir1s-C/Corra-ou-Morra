using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public InventorySystem inventorySystem;
    public Text inventoryText; // Texto na UI para exibir o inventário
    public GameObject inventoryPanel; // Painel da UI para mostrar/ocultar o inventário

    private bool isInventoryOpen = false;

    public void ToggleInventory()
    {
        isInventoryOpen = !isInventoryOpen;
        inventoryPanel.SetActive(isInventoryOpen);
        if (isInventoryOpen)
        {
            UpdateInventoryDisplay();
        }
    }

    private void UpdateInventoryDisplay()
    {
        inventoryText.text = "Inventário:\n";
        foreach (GameObject item in inventorySystem.inventory)
        {
            inventoryText.text += item.name + "\n";
        }
    }
}