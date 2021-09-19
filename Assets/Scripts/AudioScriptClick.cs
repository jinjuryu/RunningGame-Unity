using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AudioScriptClick : MonoBehaviour
{

    public AudioSource clickSound;
    

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            clickSound.Play();
    }
   
}
