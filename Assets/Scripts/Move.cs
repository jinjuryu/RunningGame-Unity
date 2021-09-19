using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    Vector3 move;
    float horizontalMove;
    float verticalMove;
    int Jumping = 0;
    private Animator anim;

    void Start()
    {
        Physics.gravity = new Vector3(0, -20f, 0);
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        verticalMove = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("isJump");
            anim.SetBool("Jumping", true);
            Jump();
        }
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            anim.SetBool("isRoll",true);
            Invoke("RollOut",0.1f);

        }
    }

    void RollOut()
    {
        anim.SetBool("isRoll", false);
    }

    void FixedUpdate()
    {
        move.Set(horizontalMove, 0, verticalMove);
        move = move.normalized * 15f * Time.deltaTime;

        GetComponent<Rigidbody>().MovePosition(transform.position + move);

        if (horizontalMove == 0 && verticalMove == 0)
        {
            anim.SetBool("isRun", false);
            return;
        }

        anim.SetBool("isRun", true);  //애니메이션
        Quaternion Roatation = Quaternion.LookRotation(move);
        GetComponent<Rigidbody>().rotation = Quaternion.Slerp(GetComponent<Rigidbody>().rotation, Roatation, 3f * Time.deltaTime);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            Jumping = 0;
            anim.SetBool("Jumping", false);
        }
       
        
    }

    void Jump()
    {
        if (Jumping == 0)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 10f, ForceMode.Impulse);
            Jumping = 1;
            
        }
        else if (Jumping == 1)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 10f, ForceMode.Impulse);
            Jumping = 2;
          
        }

    }
}