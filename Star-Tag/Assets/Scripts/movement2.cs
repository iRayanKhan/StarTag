using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2 : MonoBehaviour
{
     //public Animator animator; 

    public float moveSpeed;




    // Start is called before the first frame update



    void Start()
    {
        moveSpeed = 4.5f;
    }

    // Update is called once per frame
    void Update()
    {
      //  animator.SetFloat("Horizontal", Input.GetAxisRaw("Horizontal"));
       // Debug.Log("Test1");

       // animator.SetFloat("Vertical", Input.GetAxisRaw("Vertical"));
       // Debug.Log("Test2");

        //transform.Translate(1f*Time.deltaTime,0f,0f);
        transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime);

        if (Input.GetKeyDown("space"))
        {
            moveSpeed = 5.5f;
            Debug.Log("Player is sprinting");

        }

    }
}
