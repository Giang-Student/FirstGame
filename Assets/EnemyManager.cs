using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // Start is called before the first frame update
    private List<Enemy> enemyList;
    public EnemyManager(List<Enemy> enemyList)
    {
        this.enemyList = enemyList;
    }
    public List<Enemy> GetEnemyList()
    {
        return enemyList;
    }
    public void SetEnemyList(List<Enemy> enemyList)
    {
        this.enemyList = enemyList;
    }
    public void spawnNormalEnemy()
    {
        
    }
    public void spawnWiseEnemy()
    {
        
    }
}
