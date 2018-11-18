using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkovChain : MonoBehaviour {

    /// <summary>
    /// variables for target objects
    /// </summary>
    public float health = 20f;
    public GameObject pickupEffect;
    //public static int score = 0;
    public static int stringTotal = 9;
    //private BoxCollider Target;
    AIfighters aiFighter;
    public GameObject fightcam;
    public GameObject player;
    public GameObject mcamera;
    public GameObject controls;
    public GameObject gcontrols;
    //Chase chase;
    //public Transform[] targets;
    //private Follow followMe;
    //public static int score = DatabaseManager.score;
    //public static int score1;
    //public float speed;
   // private int current;
    //public float wtime;
    public GameObject audience;
    public GameObject incorrect1;
    public GameObject incorrect2;
    //public GameObject answer;
    //public GameObject objectectB;
    public GameObject invalidMessage;
    public GameObject validMessage;
    StringSelectManager stringSelectManager;
   // public float select = 10f;


    /// <summary>
    /// if health reduces to 0, Die method called to kill object
    /// socre is increased by 20
    /// next object is instantiated to position near prev object
    /// </summary>

    public void DamageToTarget2(float amount)
    {


        health -= amount;
        if (health <= 0f)
        {
            Die();
            //score1 += 20;
            //Target.enabled = true;

        }
        //DatabaseManager.score = score;


    }

    private void Start()
    {
        aiFighter = gameObject.GetComponent<AIfighters>();
    }
    /// <summary>
    /// when an object dies, a particle object is instantiated to the same position
    /// Destroy is called on the object
    /// check which object type and decrement the amount to show how many left per datatype
    /// use totalcounter to end game
    /// </summary>
    void Die()
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

       // Destroy(gameObject);
        Debug.Log(gameObject.name);

        switch (gameObject.tag)
        {
            case "Answer":
                audience.SetActive(true);
                mcamera.SetActive(false);
                fightcam.SetActive(true);
                controls.SetActive(false);
                gcontrols.SetActive(true);
                player.SetActive(true);
                Destroy(incorrect1);
                Destroy(incorrect2);
                gameObject.GetComponent<CharacterController>();
                aiFighter.enabled = true;
                TotalScoreManager.score += 20;
                break;
            case "NotAnswer":
                TotalScoreManager.score -= 10;
                invalidMessage.SetActive(true);
                break;

        }

    }

}
