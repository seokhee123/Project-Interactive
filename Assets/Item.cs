using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public Camera camera;
    private RaycastHit hit;
    Vector2 mousePosition;
    Spawner spawner;
    // Start is called before the first frame update
    void Start()
    {
        //camera = GameObject.Find("Main Camera").GetComponent<Camera>();
        //Invoke("Destory", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                string objectName = hit.collider.gameObject.name;
                Debug.Log(objectName);
            }
        }
    }

    void Destory()
    {
        Destroy(gameObject);
    }
}
