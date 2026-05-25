using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [Header("Animation")]
    [SerializeField] private Animator anim;

    [Header("Detection")]
    [SerializeField] private float detactionRange = 10f;
    [SerializeField] private bool isPlayerDetected;

    [Header("Attack")]
    [SerializeField] private float attackRange = 2f;
    [SerializeField] private bool isAttack;

    [Header("References")]
    [SerializeField] private Transform player;

    private Enemy enemy;
    private Rigidbody2D rb;

    private Vector3 lastPosition;

    private void Start()
    {
        isPlayerDetected = false;
        isAttack = false;

        enemy = GetComponent<Enemy>();

        anim = GetComponent<Animator>();

        rb = GetComponent<Rigidbody2D>();

        lastPosition = transform.position;
    }

    private void Update()
    {
        if(enemy.getIsDead())
        {
            return;
        }

        detectPlayer();

        playerInAttackRange();

        decideAction();

        if(isPlayerDetected)
        {
            flip(player.position);
        }

        UpdateAnimation();
    }

    // =========================
    // GIZMOS
    // =========================

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, detactionRange);

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }

    // =========================
    // PLAYER DETECTION
    // =========================

    public void detectPlayer()
    {
        if(player == null)
        {
            return;
        }

        float distance =
            Vector2.Distance(transform.position, player.position);

        isPlayerDetected = distance <= detactionRange;
    }

    public void playerInAttackRange()
    {
        if(player == null)
        {
            return;
        }

        float distance =
            Vector2.Distance(transform.position, player.position);

        isAttack = distance <= attackRange;
    }

    // =========================
    // CHASE
    // =========================

    public void chasePlayer()
    {
        transform.position =
            EnemyMovement.walkToPosition(
                player.position,
                transform.position,
                enemy.getMoveSpeed()
            );
    }

    // =========================
    // DECIDE ACTION
    // =========================

    public void decideAction()
    {
        // đứng yên khi attack
        if(isAttack)
        {
            return;
        }

        // đuổi player
        if(isPlayerDetected)
        {
            chasePlayer();
        }
    }

    // =========================
    // FLIP
    // =========================

    public void flip(Vector3 direction)
    {
        transform.localScale =
            EnemyMovement.flip(direction, transform.position);
    }

    // =========================
    // ANIMATION
    // =========================

    private void UpdateAnimation()
    {
        // kiểm tra có đang di chuyển không
        bool enemyRun =
            Vector2.Distance(transform.position, lastPosition) > 0.001f;

        lastPosition = transform.position;

        bool enemyDie = enemy.getIsDead();

        string animRun = enemy.getAnimRun();
        string animDie = enemy.getAnimDie();

        anim.SetBool(animRun, enemyRun);

        anim.SetBool(animDie, enemyDie);
    }

    // =========================
    // GETTERS
    // =========================

    public bool getIsPlayerDetected()
    {
        return isPlayerDetected;
    }

    public bool getIsAttack()
    {
        return isAttack;
    }

    public Animator getAnim()
    {
        return anim;
    }
}
// using UnityEngine;

// public class EnemyAI : MonoBehaviour
// {
//     [SerializeField] private Animator anim;
//     [SerializeField] private float detactionRange;
//     [SerializeField] private bool isPlayerDetected;
//     [SerializeField] private float attackRange;
//     [SerializeField] private bool isAttack;
//     [SerializeField] private Transform player;
//     [SerializeField] private Vector3 originalPosition;
//     private EnemyMovement enemyMovement;
//     private Enemy enemy;
//     private Rigidbody2D rb;

//     public EnemyAI(float detactionRange, float atackRange)
//     {
//         this.detactionRange = detactionRange;
//         this.attackRange = atackRange;
//         // Vector3 targetPosition;
//         // enemy = GetComponent<Enemy>();
//         // enemyMovement = new EnemyMovement(enemy.getMoveSpeed(),targetPosition);
//     }
//     private void Start()
//     {
//         isPlayerDetected =false;
//         // originalPosition = transform.position;
//         isAttack = false;
//         enemy = GetComponent<Enemy>();
//         anim = GetComponent<Animator>();
//         rb = GetComponent<Rigidbody2D>();
//         // enemyMovement = new EnemyMovement(enemy.getMoveSpeed(),targetPosition, transform.position);
//     }
//      private void Update()
//     {
//         playerInAttackRange();
//         detectPlayer();
//         decideAction();
//         flip(player.position);
//         UpdateAnimation();
//         // Vector3 targetPosition = isPlayerDetected ? player.position : null;
//         // MoveToPosition(targetPosition);
        

//     }
//     private void OnDrawGizmos()
//     {
//         // Visualize the detection radius in the editor
//         Gizmos.color = Color.blue;
//         Gizmos.DrawWireSphere(transform.position, detactionRange);
//         // Visualize the attack radius
//         Gizmos.color = Color.red;
//         Gizmos.DrawWireSphere(transform.position, attackRange);
//     }
//     public bool getIsPlayerDetected ()
//     {
//         return isPlayerDetected;
//     }
//     public void detectPlayer()
//         {
//             // if (player == null)
//             //     return;

//             float distance = Vector2.Distance(transform.position, player.position);

//             if (distance <= detactionRange)
//             {
//                 isPlayerDetected = true;
//             }
//             else
//             {
//                 isPlayerDetected = false;
//             }
//         }
//     public void chasePlayer()
//     {
//         if(isPlayerDetected)
//         {
            
//             transform.position = EnemyMovement.walkToPosition(player.position,transform.position, enemy.getMoveSpeed());
//             // Vector3 targetPosition = player.position;
//             // enemyMovement.moveToPosition(targetPosition);
//         }
//         else
//         {
//             // anim.setFloat(EnemyRun,0);
//         }
//     }
//     public void playerInAttackRange()
//     {

//         float distance = Vector2.Distance(transform.position, player.position);

//         if (distance <= attackRange)
//         {
//             isAttack = true;
//         }
//         else
//         {
//             isAttack = false;
//         }
//     }

//     public void flip(Vector3 direction)
//     {
//         if(isPlayerDetected || isAttack)
//         {
//             transform.localScale = EnemyMovement.flip(direction, transform.position);
//         }
//     }
//     public bool getIsAttack()
//     {
//         return isAttack;
//     }
//     public void decideAction()
//     {
//         if (isAttack)
//     {

//     }// make enemy stop if player in range
//     else if (isPlayerDetected)
//         {
//             chasePlayer();
//         }
//     }
//     public Animator getAnim()
//     {
//         return anim;
//     }
//     // private void UpdateAnimation()
//     // {
//     //     bool enemyRun = Mathf.Abs(rb.velocity.x) > 0.1f;
//     //     bool enemyDie = enemy.getIsDead();
//     //     getAnim().SetBool("enemyRun", enemyRun);
//     //     getAnim().SetBool("enemyDie", enemyDie);
//     // }
//     private void UpdateAnimation()
//     {
//         bool enemyRun = Mathf.Abs(rb.velocity.x) > 0.1f;
//         bool enemyDie = enemy.getIsDead();
//         string animRun = enemy.getAnimRun();
//         string animDie = enemy.getAnimDie();
//         getAnim().SetBool(animRun, enemyRun);
//         getAnim().SetBool(animDie, enemyDie);
//     }
// }
