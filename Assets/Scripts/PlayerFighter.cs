using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFighter : MonoBehaviour
{
    static Animator animator;
    public float speed = 10.0f;
    public float rotateSpeed = 100.0f;
    string[] ClipNames = { "Hook", "Hikick", "MBack", "Lkick", "MForward" };

    int currClip;


    private void Start()
    {
        animator = GetComponent<Animator>();


        //Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float move = Input.GetAxis("Vertical") * speed;
        float rotate = Input.GetAxis("Horizontal") * speed;

        move *= Time.deltaTime;
        rotate *= Time.deltaTime;

        transform.Translate(rotate, 0, move);

        if (Input.GetButton("Fire1"))
        {
            foreach (string clip in ClipNames)
            {
                animator.SetBool(clip, true);
            }
        }
        else
        {
            animator.SetBool("Idle", true);
        }

        if (move != 0)
        {
            animator.SetBool("Walk", true);
            animator.SetFloat("Turn", rotate);
            animator.SetBool("Idle", false);
        }

        else
        {
            animator.SetBool("Walk", false);
            animator.SetBool("Idle", true);
        }

        //if (Input.GetKeyDown("escape"))
        // Cursor.lockState = CursorLockMode.None;

    }
}