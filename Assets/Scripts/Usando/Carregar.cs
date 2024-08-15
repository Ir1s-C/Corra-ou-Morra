using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Carregar : MonoBehaviour

{
    bool podeInteragir = false; public GameObject Jogador;
    public string CenaACarregar;

    void Update()
    {
        if (podeInteragir == true && Input.GetKeyDown(KeyCode.F))
        {
            //Jogador.GetComponent<SalvarPosicao>().SalvarLocalizacao();
            SceneManager.LoadScene(CenaACarregar);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        podeInteragir = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        podeInteragir = false;
    }

    void OnGUI()
    {
        if (podeInteragir == true)
        {
            GUIStyle stylez = new GUIStyle();
            stylez.alignment = TextAnchor.MiddleCenter;
            GUI.skin.label.fontSize = 20;
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 50, 200, 30), "Pressione 'F'");
        }
    }
}