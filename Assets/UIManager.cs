using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // [SerializeField] private Slider healthBar;
    // [SerializeField] private Text scoreText;
    // [SerializeField] private GameObject gameOverScreen;
    // [SerializeField] private GameObject winScreen;
    // [SerializeField] private ScoreManager scoreManager;
    // [SerializeField] private Player player;
    // [SerializeField] private GameStateManager gameStateManager;
    // public UIManager(Slider healthBar, Text scoreText, GameObject gameOverScreen, GameObject winScreen)
    // {
    //     this.healthBar = healthBar;
    //     this.scoreText = scoreText;
    //     this.gameOverScreen = gameOverScreen;
    //     this.winScreen = winScreen;
    //     scoreManager = new ScoreManager();
    //     player = new Player();
    //     gameStateManager = new GameStateManager();
    // }
    // public void setHealthBar(Slider healthBar)
    // {
    //     this.healthBar = healthBar;
    // }
    // public void setScoreText(Text scoreText)
    // {
    //     this.scoreText = scoreText;
    // }
    // public void setGameOverScreen(GameObject gameOverScreen)
    // {
    //     this.gameOverScreen = gameOverScreen;
    // }
    // public void setWinScreen(GameObject winScreen)
    // {
    //     this.winScreen = winScreen;
    // }
    // public Slider getHealthBar()
    // {
    //     return healthBar;
    // }
    // public Text getScoreText()
    // {
    //     return scoreText;
    // }
    // public GameObject getGameOverScreen()
    // {
    //     return gameOverScreen;
    // }
    // public GameObject getWinScreen()
    // {
    //     return winScreen;
    // }
    // public void updateHealth(int currentHealth)
    // {
    //     healthBar.value = currentHealth;
    // }
    // public void updateScore()
    // {
    //     scoreText.text = scoreManager.GetScore().ToString();
    // }
    // public void showGameOver()
    // {
    //     getGameOverScreen().SetActive(true);
    // }
    // public void showWinScreen()
    // {
    //     getWinScreen().SetActive(true);
    // }
}
