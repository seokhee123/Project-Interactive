using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public Transform SpawnPt;
    public GameObject[] ScoreP;
    public GameObject[] Food;

    void SpawnFood()
    {
        int spawn = Random.Range(0, 2);
        Instantiate(Food[spawn], SpawnPt);
    }
    void Start()
    {
        SpawnFood();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
