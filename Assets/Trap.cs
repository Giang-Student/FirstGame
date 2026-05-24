using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
{
    Player player = other.GetComponent<Player>();
    if (player != null)
    {
        player.die();
    }
}
}
