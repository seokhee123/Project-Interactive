using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawnPos;
    public GameObject[] dropItem;
    void Start()
    {
        StartCoroutine("Spawn");
    }

    // Update is called once per frame
    void Update()
    {
        //Instantiate(dropItem[Random.Range(0, dropItem.Length)], spawnPos[Random.Range(0, spawnPos.Length)].transform.position, Quaternion.identity);
        //StartCoroutine("Spawn");
        //Invoke("Spawn", 3f);
    }

    IEnumerator Spawn(){
        int i = 0;
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            Instantiate(dropItem[Random.Range(0, dropItem.Length)], spawnPos[Random.Range(0, spawnPos.Length)].transform.position, Quaternion.identity);

        }
    }


    /*public void Spawn()
    {
        Instantiate(dropItem[Random.Range(0, dropItem.Length)], spawnPos[Random.Range(0, spawnPos.Length)].transform.position, Quaternion.identity);
    }*/
}