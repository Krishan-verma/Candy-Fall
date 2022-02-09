using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public AudioSource bgMusic;
    bool MusicEnabled=true;
    public GameObject helpPanel;
    public Animator animator;
    
    public void OnPlay()
    {
        SceneManager.LoadScene("Game");

    } 

    public void Exit()
    {
        Application.Quit();
        //Debug.Log("Game Exit");
    }

    public void Music()
    {
        if (MusicEnabled)
        {
            bgMusic.Pause();
            MusicEnabled = false;
            // Debug.Log("Background Music enabled");
        }
        else 
        {
            bgMusic.Play();
            MusicEnabled = true;
        }
    }

    public void OnHelpExit()
    {
        animator.SetBool("cancel", true);
        animator.SetBool("help", false);
    }

    public void OnHelpEnter()
    {
        animator.SetBool("help", true);
    }
}
