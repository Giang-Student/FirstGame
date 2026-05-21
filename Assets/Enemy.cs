using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Character
// , ScoreProvider
{
//     [SerializeField] protected int damage;
//     [SerializeField] protected int scoreValue;
    // [SerializeField] protected EnemyAI enemyAI;
    // [SerializeField] protected EnemyMovement enemyMovement;
    // [SerializeField] protected EnemyCombat enemyCombat;
    public Enemy(int health, float moveSpeed,
     bool isDead /*,int damage*/) : base(health, moveSpeed, isDead)
        {
            // this.damage = damage;
        }
//     protected virtual void Awake()
//     {
//         enemyAI = GetComponent<enemyAI>();
//         enemyMovement = GetComponent<EnemyMovement>();
//         enemyCombat = GetComponent<enemyCombat>();
//     }
//     public void setDamage(int damage)
//     {
//         this.damage = damage;
//     }
//     public void setScoreValue(int scoreValue)
//     {
//         this.scoreValue = scoreValue;
//     }
//     public int getDamage()
//     {
//         return damage;
//     }
//     public int getScoreValue()
//     {
//         return scoreValue;
//     }
//      protected void Die()
//     {
//         base.Die();

//         ScoreManager.Instance.AddScore(scoreValue);

//         Destroy(gameObject);
//     }
}
