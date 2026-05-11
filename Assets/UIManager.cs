using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private Slider healthBar;
    private Text scoreText;
    private GameObject gameOverScreen;
    private GameObject winScreen;
    public UIManager(Slider healthBar, Text scoreText, GameObject gameOverScreen, GameObject winScreen)
    {
        this.healthBar = healthBar;
        this.scoreText = scoreText;
        this.gameOverScreen = gameOverScreen;
        this.winScreen = winScreen;
    }
    public void setHealthBar(Slider healthBar)
    {
        this.healthBar = healthBar;
    }
    public void setScoreText(Text scoreText)
    {
        this.scoreText = scoreText;
    }
    public void setGameOverScreen(GameObject gameOverScreen)
    {
        this.gameOverScreen = gameOverScreen;
    }
    public void setWinScreen(GameObject winScreen)
    {
        this.winScreen = winScreen;
    }
    public Slider getHealthBar()
    {
        return healthBar;
    }
    public Text getScoreText()
    {
        return scoreText;
    }
    public GameObject getGameOverScreen()
    {
        return gameOverScreen;
    }
    public GameObject getWinScreen()
    {
        return winScreen;
    }
    public void updateHealth()
    {
        
    }
    public void updateScore()
    {
        
    }
    public void showGameOver()
    {
        
    }
    public void showWinScreen()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
