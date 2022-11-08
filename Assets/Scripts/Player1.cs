using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public Transform SpawnPt;
    public GameObject[] ScoreP;
    public GameObject[] Food;
    public int Score;

    GameObject Spawned;
    bool game = true;
    public void SpawnFood()
    {
        if (game)
        {
            if (Spawned != null)
            {
                Destroy(Spawned);
            }
            int spawn = Random.Range(0, 2);
            Spawned = Instantiate(Food[spawn], SpawnPt);
        }

    }
    void Start()
    {
        SpawnFood();
    }

    // Update is called once per frame
    void Update()
    {
        if (Score == 8)
        {
            Destroy(Spawned);
            game = false;
        }
        if (Score > 0 && Score < 9)
        {
            ScoreP[Score].SetActive(true);
        }
    }
}
