using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Animator animator; //stores animator component
    public float v; //veritcal movement
    public float h; //horizontal movement
    public float wback;
    public float sprint;
   

	/// <summary>
    /// call animator component
    /// </summary>
	void Start () 
    {

        animator = GetComponent<Animator>(); //assign Animator component when we start game
		
	}
	
	/// <summary>
    /// set variable to keyboard axis
    /// </summary>
	void Update () 

    {
        v = Input.GetAxis("Vertical");
        h = Input.GetAxis("Horizontal");
        wback = Input.GetAxis("Fire2");
        sprint = Input.GetAxis("Fire3");
        Sprinting();
	}
    /// <summary>
    /// animated in fixedupdate method - not restriced per frame.
    /// </summary>
    void FixedUpdate()
    {
        animator.SetFloat("Walk", v);
        animator.SetFloat("Turn", h);
        animator.SetFloat("WalkBk", wback);
        animator.SetFloat("Sprint", sprint);
    }

    /// <summary>
    /// if fire3 then sprint else do not sprint
    /// </summary>
    void Sprinting()
    {
        if(Input.GetButton("Fire3") )
        {
            sprint = 0.2f;
        }
        else 
        {
            sprint = 0.0f;
        }
    }

}
