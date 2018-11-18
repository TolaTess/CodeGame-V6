using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitTracker : MonoBehaviour {

    public Slider healthbar;
    public GameObject aI;
    public GameObject player;
    Animator animator;
    public string opponent;
    ChooseAnswer chooseAnswer;
    public GameObject controls;
    public GameObject gcontrols;
    public float wtime = 20f;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != opponent) return;

        healthbar.value -= 10;

        if(healthbar.value <=0)
        {
            if(healthbar.gameObject.name == "Slider Enemy1")
            {
                animator.SetBool("IsDead", true);
                JavaTarget1.score += 20;
                StartCoroutine("WaitForSec");
                controls.SetActive(true);
                gcontrols.SetActive(false);

            }
            if(healthbar.gameObject.name == "Slider player1")
            {
                JavaTarget1.score -= 10;
                controls.SetActive(true);
                gcontrols.SetActive(false);
            }
                
        }

    }

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(wtime);
        Destroy(aI);
        yield return new WaitForSeconds(5f);

      
    }
}
