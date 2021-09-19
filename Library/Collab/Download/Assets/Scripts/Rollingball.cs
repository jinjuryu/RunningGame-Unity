using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rollingball : MonoBehaviour
{
    public GameObject b;
    private GameObject instance;
    public Vector3 pos;
    private float moveSpeed = 2;

    // Start is called before the first frame update
    void Start()
    {
        b = (GameObject)Resources.Load("ball");
        InvokeRepeating("Rolling", 1.0f, 3.0f);
    }
    void Rolling()
    {
        int x = Random.Range(415,447);
        instance = Instantiate(b,new Vector3(x,30,400f), Quaternion.Euler(0, 0, 0));



    }
    
}
