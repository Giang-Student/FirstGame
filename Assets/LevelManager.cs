using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private int currentLevel;
    public LevelManager(int currentLevel)
    {
        this.currentLevel = currentLevel;
    }
    public int GetCurrentLevel()
    {
        return currentLevel;
    }
    public void SetCurrentLevel(int currentLevel)
    {
        this.currentLevel = currentLevel;
    }
    public bool checkWinCondition()
    {
        return ;
    }
        public bool checkLoseCondition()
    {
        return ;
    }

}
