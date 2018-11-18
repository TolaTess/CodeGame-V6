using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseAnswer : MonoBehaviour
{

    //CharacterController characterController;
    AIFighter aiFighter;
    public GameObject fightcam;
    public GameObject player;
    public GameObject mcamera;
    public GameObject controls;
    public GameObject gcontrols;
    //Chase chase;
    //public Transform[] targets;
    //private Follow followMe;
    //public static int score = DatabaseManager.score;
    public static int score1 = JavaTarget1.score;
    public float speed;
    private int current;
    public float wtime;
    public GameObject audience;
    public GameObject incorrect1;
    public GameObject incorrect2;
    public GameObject answer;
    //public GameObject objectectB;
    public GameObject invalidMessage;
    public GameObject validMessage;
    StringSelectManager stringSelectManager;
    public float select = 10f;



    // Update is called once per frame

    void Start()
    {
        //followMe = gameObject.GetComponent<Follow>();
        aiFighter = gameObject.GetComponent<AIFighter>();
        stringSelectManager = new StringSelectManager();
    }
}
    /*
    void Update()
    {
        if(transform.position != targets[current].position)
        {
            Vector3 newPos = Vector3.MoveTowards(transform.position, targets[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(newPos);
        }
        else{
            current = (current + 1) % targets.Length;
        }
        string vname = stringSelectManager.hitObject.name;
        Debug.Log("Tksnkndkn name " + stringSelectManager.hitObject.name);
        if (Input.GetKeyDown(KeyCode.T))
        {
            //string vname = stringSelectManager.hitObject.name;
            //Debug.Log("T name" + stringSelectManager.hitObject.name);
            switch (vname)
            {
                case "// at beginning":
                    //StartCoroutine(CorrectAnswer());
                    Destroy(incorrect1);
                    break;
                case "// at end":
                case "** at beginning":
                    //StartCoroutine(IncorrectAnwer());
                    Destroy(incorrect2);
                    break;
            }

        }
    }

    public void SelectObject(float amount)
    {


        health -= amount;
        if (health <= 0f)
        {
            Die();
            score += 20;
            //Target.enabled = true;

        }
        //DatabaseManager.score = score;


    }

    void Shoot()
    {

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
            StringSelectManager target = hit.transform.GetComponent<StringSelectManager>();

            if (target != null)
            {
                SelectObject(select);
            }

        }


    }

    IEnumerator CorrectAnswer()
    {
        //waits for seconds to give time for the change
        yield return new WaitForSeconds(wtime);

 
            //DatabaseManager.score = score + 20;
            JavaTarget1.score = score1 + 20;
            //validMessage.SetActive(true);
            Destroy(incorrect1);
            Destroy(incorrect2);
            //followMe.enabled = true;
            //StartCoroutine(moveToX(objectectA.transform, objectectB.transform.position, 3f));
            audience.SetActive(true);
            player.SetActive(true);
            mcamera.SetActive(false);
            fightcam.SetActive(true);
            controls.SetActive(false);
            gcontrols.SetActive(true);
            gameObject.GetComponent<CharacterController>();
            //characterController.enabled = true;
            aiFighter.enabled = true;
            //chase.enabled = true;
     
        }

    IEnumerator IncorrectAnwer()
    {
        //waits for seconds to give time for the change
        yield return new WaitForSeconds(wtime);

            //DatabaseManager.score = score - 10;
            JavaTarget1.score = score1 - 10;
            invalidMessage.SetActive(true);
    }
    /*
    IEnumerator moveToX(Transform fromPosition, Vector3 toPosition, float duration)
    {
        yield return new WaitForSeconds(5f);
        //Make sure there is only one instance of this function running

        float counter = 0;

        //Get the current position of the object to be moved
        Vector3 startPos = fromPosition.position;

        while (counter < duration)
        {
            counter += Time.deltaTime;
            fromPosition.position = Vector3.Lerp(startPos, toPosition, counter / duration);
            yield return null;
        }
    }
   */

