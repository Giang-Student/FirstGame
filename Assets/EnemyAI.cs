
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private float detactionRange;
//     [SerializeField] private float attackRange;
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 originalPosition;
    [SerializeField] private bool isPlayerDetected =false;
    [SerializeField] private EnemyPatrol patrol;
    private Enemy enemy;
    private void Start()
    {
        // originalPosition = transform.position;
        enemy = GetComponent<Enemy>();
    }
     private void Update()
    {
        detectPlayer();
        if(isPlayerDetected)
        {
            MoveToPosition(player.position);
        }
        // Vector3 targetPosition = isPlayerDetected ? player.position : null;
        // MoveToPosition(targetPosition);
    }

    // private void OnTriggerEnter2D(Collider2D other)
    // {
    //     if (other.transform == player)
    //     {
    //         Debug.Log("Player detected!");
    //         isPlayerDetected = true;
    //     }
    // }

    // private void OnTriggerExit2D(Collider2D other)
    // {
    //     if (other.transform == player)
    //     {
    //         Debug.Log("Player escaped!");
    //         isPlayerDetected = false;
    //     }
    // }

    private void MoveToPosition(Vector3 targetPosition)
    {
        // Calculate direction to the target position
        Vector3 direction = (targetPosition - transform.position).normalized;

        // Move towards the target position
        float step = enemy.getMoveSpeed() * Time.deltaTime; // Calculate the distance to move
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);
    }

    private void OnDrawGizmos()
    {
        // Visualize the detection radius in the editor
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detactionRange);
    }
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
    public void detectPlayer()
        {
            // if (player == null)
            //     return;

            float distance = Vector2.Distance(transform.position, player.position);

            if (distance <= detactionRange)
            {
                isPlayerDetected = true;
            }
            else
            {
                isPlayerDetected = false;
            }
        }
}
