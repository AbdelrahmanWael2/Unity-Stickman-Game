using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController2D controller;
    public Animator animator;

    float horizontalMovement = 0f;
    float speed = 40f;
    bool jump = false;
    bool attack = false;

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal") * speed ;

        animator.SetFloat("speed", Math.Abs(horizontalMovement));
        animator.SetBool("attack", attack);
        animator.SetBool("jump", jump);

        if (Input.GetButton("Jump"))
        {
            jump = true;
        }

        
            if (Input.GetMouseButtonDown(0))
            {
                attack = true;
            }
            
            if(Input.GetMouseButtonUp(0)) 
            {
                attack = false;
            }
      
        
        

    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMovement *Time.fixedDeltaTime, false, jump);
        jump = false;
        
    }
}
