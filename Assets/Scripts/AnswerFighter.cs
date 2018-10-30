using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerFighter : MonoBehaviour {

    public Transform player;
    static Animator animator;
    //private AnimatorStateInfo currentState;
    //private AnimatorStateInfo previousState;

    public Slider healthbar;

    // Use this for initialization
    void Start()
    {

        animator = GetComponent<Animator>();
        //currentState = animator.GetCurrentAnimatorStateInfo(0);
        //previousState = currentState;
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
        ;
    }

    /*void isDead()
    {
        if (Input.GetButton("Knockdown"))
            animator.SetBool("Knockdown", true);
        ;
    }*/

    void Update()
    {
        if (healthbar.value <= 0) return;
        Vector3 direction = player.position - this.transform.position;
        float angle = Vector3.Angle(direction, this.transform.forward);
        if(Vector3.Distance(player.position, this.transform.position) < 20 && angle < 50)
        {
            direction.y = 0;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                                                       Quaternion.LookRotation(direction), 0.1f);

            animator.SetBool("Idle", false);
            if (direction.magnitude > 5)
            {
                this.transform.Translate(0, 0, 0.2f);
                animator.SetBool("Walk", true);
                animator.SetBool("Hook", false);

            }
            else
                //IsFighting();
            {
                animator.SetBool("Hook", true);
                animator.SetBool("Walk", false);
            }
               
        }
        else
        {
            animator.SetBool("Idle", true);
            animator.SetBool("Walk", false);
            animator.SetBool("Hook", false);
        }

    }


}
