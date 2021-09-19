using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongStep : MonoBehaviour
{
    public GameObject s1, s2, s3;
    private float TimeLeft = 1.0f;
    private float nextTime = 0.0f;

    
    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("Ping", 1.5f,1.5f);
    }

    void Ping()
    {
    
        if (s1.gameObject.activeSelf)
        {

            s2.gameObject.SetActive(true);
            s1.gameObject.SetActive(false);
            //Invoke("Pong", 0.3f);
        }
        else if (s2.gameObject.activeSelf)
        {
            s3.gameObject.SetActive(true);
            s2.gameObject.SetActive(false);
            //Invoke("Pong", 0.3f);

        }
        else if (s3.gameObject.activeSelf)
        {
            s1.gameObject.SetActive(true);
            s3.gameObject.SetActive(false);
            //
        }
        //Invoke("Pong", 0.3f);
    }
    void Pong()
    {
        if (s2.gameObject.activeSelf)
            s1.gameObject.SetActive(false);
        else if (s3.gameObject.activeSelf)
            s2.gameObject.SetActive(false);
        else if (s1.gameObject.activeSelf)
            s3.gameObject.SetActive(false);

       //Invoke("Ping",1.0f);
    }
}
