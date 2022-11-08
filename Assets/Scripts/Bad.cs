using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bad : MonoBehaviour
{
    public Player1 p;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bad")
        {
            p.SpawnFood();
            p.Score++;
        }
        else if (collision.tag == "Good")
        {
            p.SpawnFood();
        }
    }
}
