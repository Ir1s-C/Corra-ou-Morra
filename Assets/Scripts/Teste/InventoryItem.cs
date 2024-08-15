using UnityEngine;

public class InventoryItem : MonoBehaviour
{
    public InventorySystem inventorySystem; // Referência ao sistema de inventário
    public GameObject[] clickableItems; // Array de itens clicáveis

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Detecta o clique do mouse
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (hit.collider != null)
            {
                GameObject clickedObject = hit.collider.gameObject;
                HandleClick(clickedObject);
            }
        }
    }

    private void HandleClick(GameObject clickedObject)
    {
        if (System.Array.Exists(clickableItems, item => item == clickedObject))
        {
            // Adiciona o item ao inventário
            inventorySystem.AddItem(clickedObject);
        }
    }
}