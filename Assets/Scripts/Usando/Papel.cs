using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Papel : MonoBehaviour
{
    public GameObject paperImage;
    public GameObject fundo;
    public Button closeButton;

    private void Start()
    {
        paperImage.SetActive(false);
        fundo.SetActive(false);
        closeButton.gameObject.SetActive(false);
        

        
        closeButton.onClick.AddListener(ClosePaperImage);
    }

    
    public void ShowPaperImage()
    {
        paperImage.SetActive(true);
        fundo.SetActive(true);
        closeButton.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    
    private void ClosePaperImage()
    {
        paperImage.SetActive(false);
        fundo.SetActive(false);
        closeButton.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            ShowPaperImage();
        }
    }
}