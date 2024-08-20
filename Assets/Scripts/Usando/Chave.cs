using UnityEngine;
using UnityEngine.SceneManagement;

public class Chave : MonoBehaviour
{
    public string keyTag = "Chave"; // A tag que o objeto chave deve ter
    public string exitTag = "Entrar"; // A tag que a área de transição deve ter
    private bool hasKey = false; // Estado se o jogador tem a chave

    void Update()
    {
        // Você pode adicionar outras lógicas de atualização aqui se necessário
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica se o jogador entrou em contato com um objeto que tem a tag 'Key'
        if (other.CompareTag(keyTag))
        {
            hasKey = true; // Atualiza o estado para que o jogador tenha a chave
            Destroy(other.gameObject); // Destroi a chave após pegar
        }

        // Verifica se o jogador entrou em uma área de transição (por exemplo, um porão)
        if (other.CompareTag(exitTag))
        {
            if (hasKey)
            {
                // Carrega a próxima cena (substitua "NextSceneName" pelo nome real da sua cena)
                SceneManager.LoadScene("Porao"); 
            }
            else
            {
                // Exemplo de mensagem ou efeito para indicar que a chave é necessária
                Debug.Log("Você precisa de uma chave para entrar aqui.");
            }
        }
    }
}