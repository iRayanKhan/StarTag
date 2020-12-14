using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Horizontal", Input.GetAxisRaw("Horizontal"));
        Debug.Log("Test1");

        animator.SetFloat("Vertical", Input.GetAxisRaw("Vertical"));
        Debug.Log("Test2");

       

    }
}
