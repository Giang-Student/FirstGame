
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
        // Enemy enemy = other.GetComponent<Enemy>();
        // if (enemy != null)
        // {
        //     enemy.TakeDamage(10);
        // }
        Debug.Log(other.name);
        Destroy(gameObject);
    }
}