using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumper : MonoBehaviour
{
    public AudioSource jump;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 30f, ForceMode.Impulse);
            jump.Play();
        }
    }

}