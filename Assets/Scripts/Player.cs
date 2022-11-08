using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform SpawnPt;
    public GameObject[] gage;
    public GameObject[] Food;
    public int Score;
    public Controller c;
    public GameObject Spawned;
    public void FoodSpawn()
    {
        if (Score == 5)
        {
            StartCoroutine(c.GameOver());
        }
        else if (Score < 5)
        {
            int spawn = Random.Range(0, 4);
            Spawned = Instantiate(Food[spawn], SpawnPt);
        }
        
    }

    private void Update()
    {
        if (Score > 0 && Score < 6)
        {
            gage[Score-1].SetActive(true);
        }
    }
}
