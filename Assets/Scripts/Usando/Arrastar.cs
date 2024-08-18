using UnityEngine;

public class Arrastar : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    private bool grudar = false;
    private bool jogadorProximo = false;

    void Start()
    {
        if (player == null)
        {
            Debug.LogError("Player não atribuído no Inspector.");
        }
    }

    void Update()
    {
        // Verifica se o jogador está pressionando a tecla P e se a mesa deve grudar
        if (Input.GetKey(KeyCode.P) && jogadorProximo)
        {
            grudar = true;
        }
        else
        {
            grudar = false;
        }

        if (grudar && player != null)
        {
            // Atualiza a posição da mesa para seguir o player com o deslocamento
            transform.position = player.transform.position + offset;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            jogadorProximo = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            jogadorProximo = false;
            grudar = false;  // Desativa o grudar quando o jogador sai do trigger
        }
    }
}