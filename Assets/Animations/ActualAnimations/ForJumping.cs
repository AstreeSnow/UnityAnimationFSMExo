using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForJumping : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
     
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            animator.SetTrigger("ToJump");
        }
    }

}
