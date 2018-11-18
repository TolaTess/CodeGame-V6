using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterChanger : MonoBehaviour {

    public Animator animator;
    public float speed = 10.0f;
    public float rotateSpeed = 100.0f;
    string[] ClipNames = { "Hook", "Hikick", "MBack", "Lkick", "MForward"};

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

        if(Input.GetButton("Fire1"))
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

        if(move != 0)
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





    /*
    private Animator animator;                     
    private AnimatorStateInfo currentState;     
    private AnimatorStateInfo previousState;

    //Animator animator; //stores animator component
    public bool v; //veritcal movement
    public float h; //horizontal movement

    // Use this for initialization
    void Start()
    {
       
        animator = GetComponent<Animator>();
        currentState = animator.GetCurrentAnimatorStateInfo(0);
        previousState = currentState;


    }


    void IsFighting()
    {
        
        if (Input.GetButton("Hook"))
            animator.SetBool("Hook", true);
        if (Input.GetButton("Hikick"))
            animator.SetBool("Hikick", true);
        if (Input.GetButton("Headb"))
            animator.SetBool("Headb", true);
        if (Input.GetButton("MBack"))
            animator.SetBool("MBack", true);
        if (Input.GetButton("Lkick"))
            animator.SetBool("Lkick", true);
        if (Input.GetButton("MForward"))
            animator.SetBool("MForward", true);
        if (Input.GetButton("Winc"))
            animator.SetBool("Winc", true);
        if (Input.GetButton("Knockdown"))
            animator.SetBool("Knockdown", true);
        ;
    }

    void Update()

    {
        v = Input.GetButton("Vertical");
        h = Input.GetAxis("Horizontal");
        IsFighting();
    }
    /// <summary>
    /// animated in fixedupdate method - not restriced per frame.
    /// </summary>
    void FixedUpdate()
    {
        animator.SetBool("Walk", v);
        animator.SetFloat("Turn", h);
    }*/
}
