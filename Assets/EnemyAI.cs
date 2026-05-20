// using System.Collections;
// using System.Collections.Generic;
// using System.Threading.Tasks.Dataflow;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
//     [SerializeField] private float detactionRange;
//     [SerializeField] private float attackRange;
//     private TransformBlock player;
//     public EnemyAI(float detactionRange, float attackRange)
//     {
//         this.detactionRange = detactionRange;
//         this.attackRange = attackRange;
//     }
//     public void setDetactionRange(float detactionRange)
//     {
//         this.detactionRange = detactionRange;
//     }
//     public void setAttackRange(float attackRange)
//     {
//         this.attackRange = attackRange;
//     }
//     public float getDetactionRange()
//     {
//         return detactionRange;
//     }
//     public float getAttackRange()
//     {
//         return attackRange;
//     }
//     public void detectPlayer()
//     {
//         if (player == null)
//             return;

//         float distance = Vector2.Distance(transform.position, player.position);

//         if (distance <= detectionRange)
//         {
//             ChasePlayer();
//         }
//     }
//     public void chasePlayer()
//     {
//         if (player == null)
//             return;

//         transform.position = Vector2.MoveTowards(
//             transform.position,
//             player.position,
//             Time.deltaTime
//         );
//     }
//     public void decideAction()
//     {
//         DetectPlayer();
//     }
//     private void Start()
//     {
//         GameObject playerObject = GameObject.FindGameObjectWithTag("Player");

//         if (playerObject != null)
//         {
//             player = playerObject.transform;
//         }
//     }

}
