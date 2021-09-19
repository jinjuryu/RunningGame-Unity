using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowLackCoin : MonoBehaviour
{
    
    public Text WarnText;
    public GameObject step; 


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject!=step)
        {
            WarnText.gameObject.SetActive(false);
        }
    }
    
}
