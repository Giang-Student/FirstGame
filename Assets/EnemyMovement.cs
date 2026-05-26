using UnityEngine;

public class EnemyMovement
{
    // fly to target
    public static Vector3 moveToPosition(Vector3 targetPosition, Vector3 currentposition, float moveSpeed)
    {
        // Calculate direction to the target position
        // Vector3 direction = (targetPosition - currentposition).normalized;

        // Move towards the target position
        float step = moveSpeed * Time.deltaTime; // Calculate the distance to move
        Vector3 nextStepPosition = Vector3.MoveTowards(currentposition, targetPosition, step);

        return nextStepPosition;

        // cần phải chỉnh enemy đi bộ trên mặt đất chứ không phải bay
    }

    //walk to target
    public static Vector3 walkToPosition(Vector3 targetPosition, Vector3 currentposition, float moveSpeed)
    {
        // Calculate direction to the target position
        // Vector3 direction = (targetPosition - currentposition).normalized;

        // Move towards the groundTarget position
        Vector3 groundTarget = new Vector3(targetPosition.x, currentposition.y, targetPosition.z);

        float step = moveSpeed * Time.deltaTime; // Calculate the distance to move

        Vector3 nextStepPosition = Vector3.MoveTowards(currentposition, groundTarget, step);

        return nextStepPosition;

        // cần phải chỉnh enemy đi bộ trên mặt đất chứ không phải bay
    }

    //     private void MoveToPosition(Vector3 targetPosition)
    // {
    //     // Calculate direction to the target position
    //     Vector3 direction = (targetPosition - transform.position).normalized;

    //     // Move towards the target position
    //     float step = enemy.getMoveSpeed() * Time.deltaTime; // Calculate the distance to move
    //     transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);
    // }

    public static Vector3 flip(Vector3 targetPosition, Vector3 currentposition)
    {
        // flip if at default enemy facing Right direction

        Vector3 rotate;

        if(targetPosition.x < currentposition.x)
        {
            rotate = new Vector3(-1,1,1);

            return rotate;
        }
        else
        {
            rotate = new Vector3(1,1,1);

            return rotate;
        }
    }
}