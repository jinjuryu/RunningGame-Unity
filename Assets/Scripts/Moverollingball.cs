using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moverollingball : MonoBehaviour
{
    void Update()
    {

        transform.Translate(Vector3.back * Time.deltaTime * 10);
        
        if (transform.position.z < 300)
        {
            Destroy(gameObject);
        }
    }
}
