using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    [SerializeField] private string gameState;
    [SerializeField] private UIManager uiManager;
    [SerializeField] private LevelManager levelManager;
    [SerializeField] private EnemyManager enemyManager;
    public GameStateManager( string gameState)
    {
        this.gameState = gameState;
    }
    public void setGameState(string gameState)
    {
        this.gameState = gameState;
    }
    public string getGameState()
    {
        return gameState;
    }
    public void StatrtGame()
    {
        gameState = "Playing";
    }
    public void RestartGame()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
    public void endGame()
    {
        gameState = "GameOver";
        uiManager.ShowGameOver();
    }
}
