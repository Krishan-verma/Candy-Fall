using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public TMP_Text highScore;
    public AudioSource audioSrc;
    public GameObject Rockets;
    public GameObject Congratulations;
    public AudioClip gameOver;
    public AudioClip congrats;

    // Start is called before the first frame update
    void Start()
    {
        highScore.text = PlayerPrefs.GetString("score");
        if(int.Parse(highScore.text) >=100)
        {
            audioSrc.PlayOneShot(gameOver);
            Rockets.SetActive(true);
            Congratulations.SetActive(true);
            audioSrc.PlayOneShot(congrats);
            audioSrc.Play();
        }
        else
        {
            audioSrc.PlayOneShot(gameOver);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnRestart()
    {
        
        SceneManager.LoadScene("Game");
    }

    public void Menu()
    {
       
        SceneManager.LoadScene("Menu");
    }
}
