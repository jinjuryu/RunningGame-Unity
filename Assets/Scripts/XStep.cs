using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XStep : MonoBehaviour
{
    void OnCollisionEnter(Collision other) //충돌 발생 함수
    {
        if (other.gameObject.CompareTag("player")) //충돌한 object가 item이면
        {
            Destroy(gameObject); //item 없앰
        }
    }
}
