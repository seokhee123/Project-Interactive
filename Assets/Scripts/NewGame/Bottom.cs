using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottom : MonoBehaviour
{
    public GameManager manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Good")
        {
            manager.score += 5;
        }
        else if (collision.tag == "Bad")
        {
            manager.score -= 5;
        }
        Destroy(collision.gameObject);
    }
}
