
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        Player player = other.GetComponent<Player>();
        if (enemy != null)
        {
            enemy.takeDamage(10);
            Debug.Log(enemy.getHealth());
        }
         else if (player != null)
        {
            player.takeDamage(10);
            Debug.Log(player.getHealth());
        }
        Debug.Log(other.name);
        Destroy(gameObject);
    }
}