using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{  
    [SerializeField] private float moveSpeed;
    public EnemyMovement(float moveSpeed)
    {
        this.moveSpeed = moveSpeed;
    }
    public void setMoveSpeed(float moveSpeed)
    {
        this.moveSpeed = moveSpeed;
    }
    public float getMoveSpeed()
    {
        return moveSpeed;
    }
    public void Move(Vector2 direction)
    {
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }
    // Start is called before the first frame update

}
