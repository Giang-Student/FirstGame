using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private float detactionRange;
    [SerializeField] private bool isPlayerDetected;
    [SerializeField] private float attackRange;
    [SerializeField] private bool isActack;
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 originalPosition;

    [SerializeField] private EnemyPatrol patrol;
    private EnemyMovement enemyMovement;
    private Enemy enemy;

    public EnemyAI(float detactionRange, float atackRange)
    {
        this.detactionRange = detactionRange;
        this.attackRange = atackRange;
        // Vector3 targetPosition;
        // enemy = GetComponent<Enemy>();
        // enemyMovement = new EnemyMovement(enemy.getMoveSpeed(),targetPosition);
    }
    private void Start()
    {
        isPlayerDetected =false;
        // originalPosition = transform.position;
        isActack = false;
        enemy = GetComponent<Enemy>();
        // enemyMovement = new EnemyMovement(enemy.getMoveSpeed(),targetPosition, transform.position);
    }
     private void Update()
    {
        playerInAttackRange();
        detectPlayer();
        if (isActack)
        {
            attack();
        }
        else if (isPlayerDetected)
        {
            chasePlayer();
        }
        flip();
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
    private void OnDrawGizmos()
    {
        // Visualize the detection radius in the editor
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, detactionRange);
        // Visualize the attack radius
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
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
    public bool getIsPlayerDetected ()
    {
        return isPlayerDetected;
    }
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
        public void chasePlayer()
        {
            if(isPlayerDetected)
            {
                transform.position = EnemyMovement.walkToPosition(player.position,transform.position, enemy.getMoveSpeed());
                // Vector3 targetPosition = player.position;
                // enemyMovement.moveToPosition(targetPosition);
            }
        }
        public void playerInAttackRange()
        {
            // if (player == null)
            //     return;

            float distance = Vector2.Distance(transform.position, player.position);

            if (distance <= attackRange)
            {
                isActack = true;
            }
            else
            {
                isActack = false;
            }
        }

        public void flip()
        {
            transform.localScale = EnemyMovement.flip(player.position, transform.position);
        }
        public void attack()
        {
            
        }
}
