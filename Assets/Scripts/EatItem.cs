using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EatItem : MonoBehaviour
{
    public Text scoreText;
    public GameObject portal1, portal2, portal3;
    public static int score;
    public AudioSource eat;
    void Start()
    {
        score = 0;
        scoreText.text = "R coin: " + score.ToString()+ " / " + DoorController.coinmax.ToString();

    }
    void OnCollisionEnter(Collision other) //충돌 발생 함수
    {
        if (other.gameObject.CompareTag("item")) //충돌한 object가 item이면
        {
            Destroy(other.gameObject); //item 없앰
            eat.Play();
            score ++; //score 증가
    
            scoreText.text = "R coin: " + score.ToString() + " / " + DoorController.coinmax.ToString(); //누적 score 출력

        } 
        if (other.gameObject.CompareTag("blackhole1")) //충돌 object가 blackhole이면
        {
            portal1.gameObject.SetActive(true);
            transform.position = portal1.transform.position;
           
        }
        if (other.gameObject.CompareTag("blackhole2")) //충돌 object가 blackhole이면
        {
            portal2.gameObject.SetActive(true);
            transform.position = portal2.transform.position;
            Debug.Log(portal2.transform.position);

        }
        if (other.gameObject.CompareTag("blackhole3")) //충돌 object가 blackhole이면
        {
            portal3.gameObject.SetActive(true);
            transform.position = portal3.transform.position;
            

        }
    }

}
