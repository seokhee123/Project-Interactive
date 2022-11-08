using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Good : MonoBehaviour
{
    public Player1 p;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Good")
        {
            p.SpawnFood();
            p.Score++;
        }
        else if (collision.tag == "Bad")
        {
            p.SpawnFood();
        }
    }
}
