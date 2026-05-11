using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private Transform spawnPoint;
    private float spawnRate;
    public EnemySpawner(Transform spawnPoint, float spawnRate)
    {
        this.spawnPoint = spawnPoint;
        this.spawnRate = spawnRate;
    }
    public void setSpawnPoint(Transform spawnPoint)
    {
        this.spawnPoint = spawnPoint;
    }
    public void setSpawnRate(float spawnRate)
    {
        this.spawnRate = spawnRate;
    }
    public Transform getSpawnPoint()
    {
        return spawnPoint;
    }
    public float getSpawnRate()
    {
        return spawnRate;
    }
    public void spawnNormalEnemy()
    {
        
    }
    public void spawnWiseEnemy()
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
