using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerFighter : MonoBehaviour {

    public Transform player;
    static Animator animator;
    string[] ClipNames = { "Headb", "Hikick", "MForward", "Lkick", "MBack", "Hook"};

    public Slider healthbar;

    // Use this for initialization
    void Start()
    {

        animator = GetComponent<Animator>();
     
    }

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
                foreach (string clip in ClipNames)
                {
                    animator.SetBool(clip, true);
                }
            }
            else
            {
                animator.SetBool("Idle", true);
                animator.SetBool("Walk", false);
            }
               
        }
        else
        {
            animator.SetBool("Idle", true);
            animator.SetBool("Walk", false);

        }

    }


}
