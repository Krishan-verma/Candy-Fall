using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager instance;
    int score = 0, lives = 2;
    int finalScore=100;
    public TMP_Text scoreText;
    private int count = 0;
    public TMP_Text topScore;
    public GameObject[] livesUI;
   
    public AudioSource audiosrc;
    
    public GameObject gameCanvas;
    

    private void Awake()
    {
        instance = this;
        

    }

    void Start()
    {
        audiosrc.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore()
    {
        if (score >= finalScore)
        {

            Invoke("GameOver", 2);

        }
        else
        {
            audiosrc.UnPause();
        }
        score++;
        scoreText.text = score.ToString();
        topScore.text = score.ToString();
       
    }

    public void DecreaseLives()
    {
        if (lives >0)
        {            
            Destroy(livesUI[lives]);
            audiosrc.Pause();
            lives--;
        }
        else
        {
            Destroy(livesUI[lives]);
            audiosrc.Stop();
            Invoke("GameOver",1.5f);
                   
        }
        
    }

    public void GameOver()
    {
        CandySpawnerCtrl.instance.StopSpawnCandy();
        PlayerPrefs.SetString("score",topScore.text);
        SceneManager.LoadScene("GameOver");

    }
   
   public void Cheat()
    {
        count += 1;
        if(count>=3)
        {
            score = 99;
            IncreaseScore();
            GameOver();
        }
    }

    void Pause()
    {
        audiosrc.Pause();
    }
}
