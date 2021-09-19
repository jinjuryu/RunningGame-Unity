using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DoorController : MonoBehaviour
{
    public GameObject Door;
    public bool doorIsOpening;
    public Image Panel;
    float time = 0f;
    float F_time = 1.0f;
    public GameObject player;
    bool temp = false;
    public static int coinmax=15;
    public Text WarnText;
    public AudioSource open;

    // Update is called once per frame
    void Update()
    {
        if (doorIsOpening == true)
        {
            
            Door.transform.Translate(Vector3.up * Time.deltaTime * 5);
           if (player.transform.position.z > Door.transform.position.z && temp==false)
            {
                Fade();
            
            }
            
        }
        if (Door.transform.position.y > 30f)
        {
            doorIsOpening = false;
        }

       


    }
    void OnCollisionEnter(Collision other) //충돌 발생 함수
    {
        if (other.gameObject.CompareTag("player")) 
        {
            if (EatItem.score >= coinmax)
            {
                WarnText.gameObject.SetActive(false);
                doorIsOpening = true;
                open.Play();
            }

            else
                WarnText.gameObject.SetActive(true);
        }
        
       

    }

    public void Fade()
    {
        temp = true;
        StartCoroutine(FadeFlow());
    
       
    }
    IEnumerator FadeFlow()
    {
        Panel.gameObject.SetActive(true);
        time = 0f;
        Color alpha = Panel.color;
        while (alpha.a < 1f)
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(0, 1, time);
            Panel.color = alpha;
            yield return null;
        }
        time = 0f;
        ChangeMap.Levelup();    //map change
        yield return new WaitForSeconds(1f);

        Panel.gameObject.SetActive(false);
        
        yield return null;
        
    }
    
    
}
