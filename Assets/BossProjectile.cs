using UnityEngine;

public class BossProjectile : MonoBehaviour
{
    [SerializeField] private float speed = 8f;

    private Vector2 targetPosition;

    public void setSpeed(float speed)
    {
        this.speed = speed;
    }

    public void setTargetPosition(Vector2 targetPosition)
    {
        this.targetPosition = targetPosition;
    }

    public float getSpeed()
    {
        return speed;
    }

    public Vector2 getTargetPosition()
    {
        return targetPosition;
    }

    public void SetTarget(Vector2 target)
    {
        targetPosition = target;
    }

    private void Update()
    {
        transform.position =
            Vector2.MoveTowards(
                transform.position,
                targetPosition,
                speed * Time.deltaTime
            );

        // destroy khi tới nơi

        if(Vector2.Distance(transform.position, targetPosition) < 0.1f)
        {
            Destroy(gameObject);
        }
    }
}