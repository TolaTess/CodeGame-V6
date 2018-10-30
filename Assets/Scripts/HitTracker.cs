using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitTracker : MonoBehaviour {

    public Slider healthbar;
    Animator animator;
    public string opponent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != opponent) return;

        healthbar.value -= 10;

        if(healthbar.value <=0)
        {
            animator.SetBool("IsDead", true);

            animator.SetBool("Win", true);
          
        }
    }

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
