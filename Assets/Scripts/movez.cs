using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movez : MonoBehaviour
{
    float rightMax = 5.0f; //좌로 이동가능한 (x)최대값
    float leftMax = -5.0f; //우로 이동가능한 (x)최대값
    float currentPosition, firstPosition; //현재 위치(x) 저장
    float direction = 3.0f; //이동속도+방향

    void Start()

    {

        currentPosition = transform.position.z;
        firstPosition = transform.position.z;

    }

   /* void OnCollisionEnter(Collision other) //충돌 발생 함수
    {
        if (other.gameObject.CompareTag("player")) //충돌한 object가 item이면
        {
            other.gameObject.transform.position = transform.position;

        }
    }
    */


    void Update()

    {

        currentPosition += Time.deltaTime * direction;

        if (currentPosition >= firstPosition + rightMax)
        {
            direction *= -1;
            currentPosition = firstPosition + rightMax;
        }

        else if (currentPosition <= firstPosition + leftMax)

        {
            direction *= -1;
            currentPosition = firstPosition + leftMax;
        }

        transform.position = new Vector3(transform.position.x, transform.position.y, currentPosition);

    }
}