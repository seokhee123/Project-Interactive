using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public GameObject gage;
    public Transform[] spawn;
    public GameObject[] foods;
    public int score;
    public SpriteRenderer sr;

    bool b = true;
    void Start()
    {
        gage.transform.localScale = new Vector3(0, 0.49375f, 1);
    }

    void GageCtrl()
    {
        if (score < 0) score = 0;
        gage.transform.localScale = new Vector3((float)score / (float)100, 0.49375f, 1);
    }
    void ColorCtrl()
    {
        Color c = sr.color;
        if (0 <= score && score < 20)
        {
            c.r = 255; c.g = 0;
        }
        else if (20 <= score && score < 40)
        {
            c.r = 191; c.g = 63;
        }
        else if (40 <= score && score < 60)
        {
            c.r = 127; c.g = 127;
        }
        else if (60 <= score && score < 80)
        {
            c.r = 63; c.g = 191;
        }
        else if (60 <= score && score < 80)
        {
            c.r = 0; c.g = 255;
        }
        sr.color = c;
    }
    void Update()
    {
        ColorCtrl();
        GageCtrl();
        StartCoroutine(spawnObj());
    }

    IEnumerator spawnObj()
    {
        if (b)
        {
            b = false;
            int r1 = Random.Range(0, 7);
            int r2 = Random.Range(0, 7);
            Instantiate(foods[r1], spawn[r2]);
            yield return new WaitForSeconds(0.5f);
            b = true;
        }

    }
}
