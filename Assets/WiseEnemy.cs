using UnityEngine;

public class WiseEnemy : Enemy
{
    [SerializeField] private float attackRate = 1f;
    [SerializeField] private float skillCooldown = 5f;
    private float timeA = 0f;
    private float timeS = 0f;
    [SerializeField] private float originHealth;
    // [SerializeField] private EnemyAI enemyAI;
    [SerializeField] private float patroDistance;
    private Animator anim;
    [SerializeField] private Transform attackPoint;

    [SerializeField] private float attackRange = 1.5f;

    [SerializeField] private int damage = 10;

    [SerializeField] private LayerMask playerLayer;
    [SerializeField] private GameObject projectilePrefab;
    private void Awake()
    {
        originHealth = getHealth();

        anim = GetComponent<Animator>();

        if(enemyAI == null)
        {
            enemyAI = GetComponent<EnemyAI>();
        }
    }
    private void Update()
    {
        if(getIsDead())
        {
            return;
        }
        // reset animation
        // anim.SetBool("Battack", false);
        // anim.SetBool("Bspattack", false);

        // chỉ attack khi player trong range
        if(enemyAI.getIsAttack())
        {
            // special attack
            if(coolDownSkill())
            {
                specialAttack();
            }
            // normal attack
            else if(coolDownAttack())
            {
                attack();
            }
        }
    }

    // NORMAL ATTACK

    public void attack()
    {
        anim.SetBool("Battack", true);

        DealDamage();
    }
    public void DealDamage()
{
    Collider2D hitPlayer =
        Physics2D.OverlapCircle(
            attackPoint.position,
            attackRange,
            playerLayer
        );

    if(hitPlayer != null)
    {
        Player player = hitPlayer.GetComponent<Player>();

        if(player != null)
        {
            player.takeDamage(damage);
        }
    }
}

    // SPECIAL ATTACK

    public void specialAttack()
    {
        if(getHealth() <= originHealth * 0.5f)
        {
            anim.SetBool("Bspattack", true);
            // anim.SetTrigger("Battack");
            SpawnRainAttack();
        }
    }
    public void SpawnRainAttack()
{
    // khóa vị trí player hiện tại
    Vector2 lockedPosition = player.position;

    // spawn 4 viên đạn
    for(int i = 0; i < 4; i++)
    {
        // random vị trí trên trời
        Vector2 spawnPosition =
            new Vector2(
                lockedPosition.x + Random.Range(-3f, 3f),
                lockedPosition.y + 6f
            );

        GameObject bullet =
            Instantiate(
                projectilePrefab,
                spawnPosition,
                Quaternion.identity
            );

        BossProjectile projectile =
            bullet.GetComponent<BossProjectile>();

        projectile.SetTarget(lockedPosition);
    }
}

    // COOLDOWN

    public bool coolDownAttack()
    {
        timeA += Time.deltaTime;

        if(timeA >= attackRate)
        {
            timeA = 0f;
            return true;
        }

        return false;
    }

    public bool coolDownSkill()
    {
        timeS += Time.deltaTime;

        if(timeS >= skillCooldown)
        {
            timeS = 0f;
            return true;
        }

        return false;
    }

    // ANIMATION NAMES

    public override string getAnimRun()
    {
        return "BRun";
    }

    public override string getAnimDie()
    {
        return "BDie";
    }

    // PATROL

    public void setPatroDistance(float patroDistance)
    {
        this.patroDistance = patroDistance;
    }

    public float getPatroDistance()
    {
        return patroDistance;
    }
    private void OnDrawGizmosSelected()
{
    if(attackPoint == null)
    {
        return;
    }

    Gizmos.color = Color.red;

    Gizmos.DrawWireSphere(
        attackPoint.position,
        attackRange
    );
}
}
