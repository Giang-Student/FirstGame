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

    public void setAttackRate(float attackRate)
    {
        this.attackRate = attackRate;
    }

    public void setSkillCooldown(float skillCooldown)
    {
        this.skillCooldown = skillCooldown;
    }

    public void setTimeA(float timeA)
    {
        this.timeA = timeA;
    }

    public void setTimeS(float timeS)
    {
        this.timeS = timeS;
    }

    public void setOriginHealth(float originHealth)
    {
        this.originHealth = originHealth;
    }

    public void setPatroDistance(float patroDistance)
    {
        this.patroDistance = patroDistance;
    }

    public void setAnim(Animator anim)
    {
        this.anim = anim;
    }

    public void setAttackPoint(Transform attackPoint)
    {
        this.attackPoint = attackPoint;
    }

    public void setAttackRange(float attackRange)
    {
        this.attackRange = attackRange;
    }

    public void setDamage(int damage)
    {
        this.damage = damage;
    }

    public void setPlayerLayer(LayerMask playerLayer)
    {
        this.playerLayer = playerLayer;
    }

    public void setProjectilePrefab(GameObject projectilePrefab)
    {
        this.projectilePrefab = projectilePrefab;
    }

    public float getAttackRate()
    {
        return attackRate;
    }

    public float getSkillCooldown()
    {
        return skillCooldown;
    }

    public float getTimeA()
    {
        return timeA;
    }

    public float getTimeS()
    {
        return timeS;
    }

    public float getOriginHealth()
    {
        return originHealth;
    }

    public float getPatroDistance()
    {
        return patroDistance;
    }

    public Animator getAnim()
    {
        return anim;
    }

    public Transform getAttackPoint()
    {
        return attackPoint;
    }

    public float getAttackRange()
    {
        return attackRange;
    }

    public int getDamage()
    {
        return damage;
    }

    public LayerMask getPlayerLayer()
    {
        return playerLayer;
    }

    public GameObject getProjectilePrefab()
    {
        return projectilePrefab;
    }

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

    public override string getAnimRun()
    {
        return "BRun";
    }

    public override string getAnimDie()
    {
        return "BDie";
    }

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