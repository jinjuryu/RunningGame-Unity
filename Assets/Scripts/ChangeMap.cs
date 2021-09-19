using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeMap : MonoBehaviour
{
    public static void Levelup()
    {
        
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
}
