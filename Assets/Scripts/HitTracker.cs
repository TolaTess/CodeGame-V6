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
    public static int score;
    public float wtime = 20f;
    public GameObject pickupEffect;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != opponent) return;

        healthbar.value -= 1;

        if (healthbar.value >= 1 || healthbar.value <= 99)
        {
            if (healthbar.gameObject.name == "Slider Enemy1")
            {
                TotalScoreManager.score += 20;

            }
            if (healthbar.gameObject.name == "Slider player1")
            {
                TotalScoreManager.score -= 10;
            }
        }
       
            if (healthbar.value <= 0)
            {
                if (healthbar.gameObject.name == "Slider Enemy1")
                {

                    animator.SetBool("IsDead", true);
                    StartCoroutine("WaitForSec");
                    controls.SetActive(true);
                    gcontrols.SetActive(false);

                }
                if (healthbar.gameObject.name == "Slider player1")
                {
                    TotalScoreManager.score -= 5;

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
        //Instantiate(pickupEffect, aI.transform.position, aI.transform.rotation);

        yield return new WaitForSeconds(5f);

      
    }
}
