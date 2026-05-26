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

    public void setAnim(Animator anim)
    {
        this.anim = anim;
    }

    public void setDetactionRange(float detactionRange)
    {
        this.detactionRange = detactionRange;
    }

    public void setIsPlayerDetected(bool isPlayerDetected)
    {
        this.isPlayerDetected = isPlayerDetected;
    }

    public void setAttackRange(float attackRange)
    {
        this.attackRange = attackRange;
    }

    public void setIsAttack(bool isAttack)
    {
        this.isAttack = isAttack;
    }

    public void setPlayer(Transform player)
    {
        this.player = player;
    }

    public void setEnemy(Enemy enemy)
    {
        this.enemy = enemy;
    }

    public void setRb(Rigidbody2D rb)
    {
        this.rb = rb;
    }

    public void setLastPosition(Vector3 lastPosition)
    {
        this.lastPosition = lastPosition;
    }

    public Animator getAnim()
    {
        return anim;
    }

    public float getDetactionRange()
    {
        return detactionRange;
    }

    public bool getIsPlayerDetected()
    {
        return isPlayerDetected;
    }

    public float getAttackRange()
    {
        return attackRange;
    }

    public bool getIsAttack()
    {
        return isAttack;
    }

    public Transform getPlayer()
    {
        return player;
    }

    public Enemy getEnemy()
    {
        return enemy;
    }

    public Rigidbody2D getRb()
    {
        return rb;
    }

    public Vector3 getLastPosition()
    {
        return lastPosition;
    }

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

    public void chasePlayer()
    {
        transform.position =
            EnemyMovement.walkToPosition(
                player.position,
                transform.position,
                enemy.getMoveSpeed()
            );
    }

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

    public void flip(Vector3 direction)
    {
        transform.localScale =
            EnemyMovement.flip(direction, transform.position);
    }

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
}