using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    private string GameState;
    public GameStateManager( string GameState)
    {
        this.GameState = GameState;
    }
    public void setGameState(string GameState)
    {
        this.GameState = GameState;
    }
    public string getGameState()
    {
        return GameState;
    }
    public void StatrtGame()
    {
        
    }
    public void RestartGame()
    {
        
    }
    public void endGame()
    {
        
    }
}
