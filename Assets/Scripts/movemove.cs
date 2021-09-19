using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemove : MonoBehaviour
{
    public float rightMax = 5.0f; //좌로 이동가능한 (x)최대값
    public float leftMax = -5.0f; //우로 이동가능한 (x)최대값
    float currentPosition, firstPosition; //현재 위치(x) 저장
    float direction = 3.0f; //이동속도+방향




    void Start()

    {

        currentPosition = transform.position.x;
        firstPosition = transform.position.x;

    }




    void Update()

    {

        currentPosition += Time.deltaTime * direction;

        if (currentPosition >= firstPosition+rightMax)
        {
            direction *= -1;
            currentPosition = firstPosition+ rightMax;
        }

        else if (currentPosition <= firstPosition+leftMax)

        {
            direction *= -1;
            currentPosition = firstPosition+leftMax;
        }

        transform.position = new Vector3(currentPosition, transform.position.y,transform.position.z );

    }
}
