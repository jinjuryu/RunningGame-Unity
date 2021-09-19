using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameover : MonoBehaviour
{
    int life = 3;
    Vector3 currentPosition;
    public GameObject l1, l2, l3,panel;
    void Start()
    {
        currentPosition = transform.position;
        l1.gameObject.SetActive(true);
        l2.gameObject.SetActive(true);
        l3.gameObject.SetActive(true);

    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10.0f)
        {
            transform.position = currentPosition;
            life--;
            if (life == 2)
                l1.gameObject.SetActive(false);
            else if (life == 1)
                l2.gameObject.SetActive(false);
            else if (life == 0) { 
                l3.gameObject.SetActive(false);
                panel.gameObject.SetActive(true);
                Invoke("GotoMain", 2);    

            }
           
        }
      
}
   void GotoMain()
    {
        SceneManager.LoadScene("Main");

    }
}