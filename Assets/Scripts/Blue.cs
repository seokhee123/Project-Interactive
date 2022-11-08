using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue : MonoBehaviour
{
    public Player player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Good")
        {
            if (player.Spawned != null)
            {
                Destroy(player.Spawned);
            }
            player.Score++;
            player.FoodSpawn();
        }
        else if (collision.tag == "Bad")
        {
            if (player.Spawned != null)
            {
                Destroy(player.Spawned);
            }
            player.FoodSpawn();
        }
    }
}
