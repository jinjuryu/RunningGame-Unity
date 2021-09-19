using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveup : MonoBehaviour
{
    public float upMax = 5.0f; //좌로 이동가능한 (x)최대값
    public float downMax = 2.0f; //우로 이동가능한 (x)최대값
    float currentPosition; //현재 위치(x) 저장
    float direction = 3.0f; //이동속도+방향




    void Start()

    {

        currentPosition = transform.position.y;

    }




    void Update()

    {

        currentPosition += Time.deltaTime * direction;

        if (currentPosition >= upMax)
        {
            direction *= -1;
            currentPosition = upMax;
        }

        else if (currentPosition <= downMax)

        {
            direction *= -1;
            currentPosition = downMax;
        }

        transform.position = new Vector3(transform.position.x,currentPosition , transform.position.z);

    }
}
