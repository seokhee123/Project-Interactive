using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Camera getCamera;
    private RaycastHit hit;
    GameObject hitObj;
    float time;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = getCamera.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                string objectName = hit.collider.gameObject.name;
                Debug.Log(objectName);
                hitObj = hit.collider.gameObject;
                if(objectName == "river")
                {
                    StartCoroutine("river");
                }
                else if(objectName == "windmill")
                {
                    StartCoroutine("windmill");
                }
                else if(objectName == "drain")
                {
                    StartCoroutine("drain");
                }
            }
        }
    }

    IEnumerator windmill() //윈드밀 회전
    {
        time = 3.6f;
        while (time > 0)
        {
            hitObj.transform.Rotate(0, 0, -1);
            time -= Time.deltaTime;
            yield return null;
        }
    }

    IEnumerator drain()
    {
        time = 3f;
        while (time > 0)
        {
            hitObj.transform.GetChild(0).gameObject.SetActive(true);
            time -= Time.deltaTime;
            yield return null;
        }
        hitObj.transform.GetChild(0).gameObject.SetActive(false);
    }

    IEnumerator river()
    {
        yield return null;
    }
}
