using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerFighter : MonoBehaviour {

    private Animator animator;
    private AnimatorStateInfo currentState;
    private AnimatorStateInfo previousState;

    // Use this for initialization
    void Start()
    {

        animator = GetComponent<Animator>();
        currentState = animator.GetCurrentAnimatorStateInfo(0);
        previousState = currentState;

        //animator = GetComponent<Animator>();

    }


    void IsFighting()
    {

        if (Input.GetButton("Hook"))
            animator.SetBool("Headb", true);
        if (Input.GetButton("Hikick"))
            animator.SetBool("Hikick", true);
        if (Input.GetButton("Headb"))
            animator.SetBool("Hook", true);
        if (Input.GetButton("MBack"))
            animator.SetBool("MForward", true);
        if (Input.GetButton("Lkick"))
            animator.SetBool("Lkick", true);
        if (Input.GetButton("MForward"))
            animator.SetBool("MBack", true);
        if (Input.GetButton("Winc"))
            animator.SetBool("Knockdown", true);
        ;
    }

    void Update()

    {

        IsFighting();
        isDead();
    }

    void isDead()
    {
        if(Input.GetButton("Winc"))
        {
            Destroy(gameObject);
        }
    }

}
