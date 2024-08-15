using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public List<GameObject> inventory = new List<GameObject>(); // Lista para armazenar os itens

    public void AddItem(GameObject item)
    {
        if (!inventory.Contains(item))
        {
            inventory.Add(item);
            Debug.Log($"Item adicionado ao inventário: {item.name}");
            // Adicione aqui o código para manipular o item, como desativar o item na cena
            item.SetActive(false); // Desativa o item na cena, por exemplo
        }
    }
}