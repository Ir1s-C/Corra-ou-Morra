using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    //private static AudioManager instance;
    public AudioClip trilhaCasa;
    public AudioClip trilhaMenu;
    private AudioSource player;
    void Start()
    {
        player = GetComponent<AudioSource>();
        //if(instance == null)
        //{
        //  instance = this;
        DontDestroyOnLoad(gameObject);
        //}
        //else
        //{
        //  Destroy(gameObject);
        //}

        player.clip = trilhaMenu;
        player.Play();
    }

    private void Update()
    {
        if(SceneManager.GetActiveScene().name == "DentroDaCasa")
        {
            player.Stop();
            player.clip = trilhaCasa;
            player.Play();
        }
        if(SceneManager.GetActiveScene().name == "DentroDaCasa")
        {
            player.Stop();
            player.clip = trilhaCasa;
            player.Play();
        }if(SceneManager.GetActiveScene().name == "DentroDaCasa")
        {
            player.Stop();
            player.clip = trilhaCasa;
            player.Play();
        }
    }
}
