using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverUi;
    [SerializeField] private Player player;
    [SerializeField] private GameObject gameWinUi;
    [SerializeField] private WiseEnemy boss;

    private bool isGameOver = false;
    private bool isGameWin = false;

    void Start()
    {
        gameOverUi.SetActive(false);
        
        gameWinUi.SetActive(false);
    }

    void Update()
    {
        if(player.getIsDead())
        {
            gameOverUi.SetActive(true);
        }
        else if(boss.getIsDead())
        {
            gameWinUi.SetActive(false);
        }
    }

    public void GameOver()
    {
        isGameOver = true;
        Time.timeScale = 0;
        gameOverUi.SetActive(true);
    }
    public void RestarGame()
    {
        isGameOver = false;
        Time.timeScale = 1;
        SceneManager.LoadScene("GameScene");

    }
}