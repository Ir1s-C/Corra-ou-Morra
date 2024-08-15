using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    public GameObject[] clickableObjects; // Array de objetos que podem ser clicados

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
        if (System.Array.Exists(clickableObjects, obj => obj == clickedObject))
        {
            // Adicione a lógica específica para o que deve acontecer quando o objeto for clicado
            Debug.Log($"Você clicou no objeto: {clickedObject.name}");

            // Exemplo: mudar a cor do objeto clicado
            SpriteRenderer spriteRenderer = clickedObject.GetComponent<SpriteRenderer>();
            if (spriteRenderer != null)
            {
                spriteRenderer.color = Color.red;
            }
        }
    }
}