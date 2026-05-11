using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Player player;
    private List<Enemy> enemyList;
    private int currentLevel;
    private int score;
    private string gameState;
    public GameManager(Player player, List<Enemy> enemyList, int currentLevel, int score, string gameState)
    {
        this.player = player;
        this.enemyList = enemyList;
        this.currentLevel = currentLevel;
        this.score = score;
        this.gameState = gameState;
    }
    public void setPlayer(Player player)
    {
        this.player = player;
    }
    public void setEnemyList(List<Enemy> enemyList)
    {
        this.enemyList = enemyList;
    }
    public void setCurrentLevel(int currentLevel)
    {
        this.currentLevel = currentLevel;
    }
    public void setScore(int score)
    {
        this.score = score;
    }
    public void setGameState(string gameState)
    {
        this.gameState = gameState;
    }
    public Player getPlayer()
    {
        return player;
    }
    public List<Enemy> getEnemyList()
    {
        return enemyList;
    }
    public int getCurrentLevel()
    {
        return currentLevel;
    }
    public int getScore()
    {
        return score;
    }
    public string getGameState()
    {
        return gameState;
    }
    public void startGame()
    {
        
    }
    public void SpawnEnemy()
    {
        
    }
    public void checkWinCondition()
    {
        
    }
    public void checkLoseCondition()
    {
        
    }
    public void restartGame()
    {
        
    }
    public void endGame()
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
