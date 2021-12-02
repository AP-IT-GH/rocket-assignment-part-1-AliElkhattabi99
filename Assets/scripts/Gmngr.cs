using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gmngr : MonoBehaviour
{
    public GameObject Player;
    public GameObject mainCnvs;
    public GameObject goCnvs;
    private Health health;
    public enum GameStates
    {
        Playing,
        Gameover
    }
    public GameStates gameState = GameStates.Playing;

    int score = 0;
    public Text ScoreText;
    public Text win;
    public string lvl;

    public void AddScore()
    {
        score++;
        ScoreText.text = score.ToString();
        if (score == 5)
        {
            win.text = "You Win!";
            Time.timeScale = 0f;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        if (Player == null)
        {
            Player = GameObject.FindWithTag("Player");
        }
        health = Player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {

        switch (gameState)
        {
            case GameStates.Playing:
                if (!health.isAlive)
                {
                    gameState = GameStates.Gameover;
                    mainCnvs.SetActive(false);
                    goCnvs.SetActive(true);
                }
                break;
            case GameStates.Gameover:
                break;
            default:
                break;
        }

    }
  

}
