using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] private Transform pointA;
    [SerializeField] private Transform pointB;
    [SerializeField] private Rigidbody2D rb;
    private Transform currentPoint;
    [SerializeField] private Enemy enemy;
    [SerializeField] private EnemyAI ememyAI;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = pointB.transform;

    }
    private void Update()
    {
        if(!ememyAI.getIsPlayerDetected())
            {
            // Vector2 point = currentPoint.position - transform.position;
            if(currentPoint == pointB.transform)
            {
               Vector3 targetPosition = pointB.position;
            //    MoveToPosition(targetPosition);
               transform.position = EnemyMovement.moveToPosition(targetPosition,transform.position, enemy.getMoveSpeed());
            }
            else
            {
                // rb.velocity = new Vector2(-enemy.getMoveSpeed(), 0);
                Vector3 targetPosition = pointA.position;
            //    MoveToPosition(targetPosition);
               transform.position = EnemyMovement.moveToPosition(targetPosition,transform.position, enemy.getMoveSpeed());
            }
            if(Vector2.Distance(transform.position, currentPoint.position)<1f && currentPoint == pointB.transform)
            {
                currentPoint = pointA.transform;
            }
            if(Vector2.Distance(transform.position, currentPoint.position)<1f && currentPoint == pointA.transform)
            {
                currentPoint = pointB.transform;
            }
        }
        // xong patrol
        // if(enemy.die())
        // {
        //     enemy.setMoveSpeed(0);
        // }

    }
    
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(pointA.position, 0.5f);
        Gizmos.DrawWireSphere(pointB.position, 0.5f);
        Gizmos.DrawLine(pointA.position,pointB.position);
    }
    // là cái gì ??
}
