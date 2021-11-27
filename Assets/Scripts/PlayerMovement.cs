using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public CharacterController2D controller;

    float horizontalMove = 0f;

    public float runSpeed = 40f;

    bool jump = false;

    bool crouch = false;

    public Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame


    public void onLanding(){
        animator.SetBool("jumping",false);
    }
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        
        animator.SetFloat("speed",Mathf.Abs(horizontalMove));
        Debug.Log(Mathf.Abs(horizontalMove));

        if(crouch == true){
            Debug.Log("Crouched");
        }
        if(Input.GetButtonDown("Jump") && controller.jumpEnabled){
            jump = true;
            animator.SetBool("jumping",true);
            
        }

        
        
        if(Input.GetButtonDown("Crouch")){
            crouch = true;
        } else if(Input.GetButtonDown("Crouch")){
            crouch = false;
        }

    }

    void FixedUpdate(){
        controller.Move(horizontalMove * Time.fixedDeltaTime , crouch, jump);
        jump = false;
        crouch = false;
    }
}
