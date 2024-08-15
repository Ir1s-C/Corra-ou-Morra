using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   public void PlayGame()
   {
      SceneManager.LoadScene("Game");
   }

   public void Creditos()
   {
      SceneManager.LoadScene("Creditos");
   }

   public void Voltar()
   {
      SceneManager.LoadScene("Menu");
   }
   
   public void Sair()
   {
      Application.Quit();
   }
}
