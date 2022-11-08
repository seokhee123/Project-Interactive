using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public Player p1, p2;
    public GameObject btn;
    public GameObject btn2;
    public GameObject[] UIs;
    public GameObject[] Winner;
    int a, b;
    public void GameStart()
    {
        for (int i = 0; i < 8; i++)
        {
            UIs[i].SetActive(true);
        }
        p1.FoodSpawn();
        p2.FoodSpawn();
        btn.SetActive(false);
    }
    public IEnumerator GameOver()
    {
        a = p1.Score;
        b = p2.Score;
        p1.Spawned.SetActive(false);
        p2.Spawned.SetActive(false);
        for (int i = 0; i < 8; i++)
        {
            UIs[i].SetActive(false);
        }

        if (a > b)
        {
            Winner[0].SetActive(true);
        }
        else if (a < b)
        {
            Winner[1].SetActive(true);
        }
        yield return new WaitForSeconds(2f);
        btn2.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
