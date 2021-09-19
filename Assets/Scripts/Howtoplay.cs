using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Howtoplay : MonoBehaviour
{
    public GameObject image, main;

   
    public void BacktoMain()
    {
        image.gameObject.SetActive(false);
        main.gameObject.SetActive(true);
    }
}
