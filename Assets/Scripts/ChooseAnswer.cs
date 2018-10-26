using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseAnswer : MonoBehaviour {

    //CharacterController characterController;
    AnswerFighter answerFighter;
    Rigidbody rbody;
    public Transform[] targets;
    private Follow followMe;
    public static int score = DatabaseManager.score;
    public float speed;
    private int current;
    public float wtime;
    private StringSelectManager ssm;
    public GameObject prevObject;
    public GameObject incorrect1;
    public GameObject incorrect2;
    public GameObject objectectA;
    public GameObject objectectB;
    public GameObject invalidMessage;
    public GameObject validMessage;

	
	// Update is called once per frame
	void Update () {
        if(transform.position != targets[current].position)
        {
            Vector3 newPos = Vector3.MoveTowards(transform.position, targets[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(newPos);
        }
        else{
            current = (current + 1) % targets.Length;
        }
        StartCoroutine(StartFight());
    }

    void Start()
    {
        followMe = gameObject.GetComponent<Follow>();
       // characterController = gameObject.GetComponent<CharacterController>();
        answerFighter = gameObject.GetComponent<AnswerFighter>();
        rbody = gameObject.GetComponent<Rigidbody>();
    }

    IEnumerator StartFight()
    {
        //waits for seconds to give time for the change
        yield return new WaitForSeconds(wtime);
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (incorrect1.CompareTag("NotAnswer"))
            {
                DatabaseManager.score = score - 10;
                invalidMessage.SetActive(true);
                Destroy(incorrect1);
                if (incorrect2 == null)
                {
                    DatabaseManager.score = score + 5;
                    invalidMessage.SetActive(false);
                    //followMe.enabled = true;
                   // StartCoroutine(moveToX(objectectA.transform, objectectB.transform.position, 3f));
                    prevObject.SetActive(true);
                    gameObject.GetComponent<CharacterController>();
                    //characterController.enabled = true;
                    answerFighter.enabled = true;
                    rbody.isKinematic = true;
                }
            }
            else
            {
                DatabaseManager.score = score + 20;
                validMessage.SetActive(true);
                Destroy(incorrect1);
                Destroy(incorrect2);
                //followMe.enabled = true;
               // StartCoroutine(moveToX(objectectA.transform, objectectB.transform.position, 3f));
                prevObject.SetActive(true);
                gameObject.GetComponent<CharacterController>();
                //characterController.enabled = true;
                answerFighter.enabled = true;
                rbody.isKinematic = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (incorrect2.CompareTag("NotAnswer"))
            {
                DatabaseManager.score = score - 10;
                invalidMessage.SetActive(true);
                Destroy(incorrect2);
                if (incorrect1 == null)
                {
                    DatabaseManager.score = score + 5;
                    invalidMessage.SetActive(false);
                    //followMe.enabled = true;
                   // StartCoroutine(moveToX(objectectA.transform, objectectB.transform.position, 3f));
                    prevObject.SetActive(true);
                    gameObject.GetComponent<CharacterController>();
                    //characterController.enabled = true;
                    answerFighter.enabled = true;
                    rbody.isKinematic = true;
                }
            }
            else
            {
                DatabaseManager.score = score + 20;
                validMessage.SetActive(true);
                Destroy(incorrect1);
                Destroy(incorrect2);
                //followMe.enabled = true;
               // StartCoroutine(moveToX(objectectA.transform, objectectB.transform.position, 3f));
                prevObject.SetActive(true);
                gameObject.GetComponent<CharacterController>();
                //characterController.enabled = true;
                answerFighter.enabled = true;
                rbody.isKinematic = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
         
            DatabaseManager.score = score + 20;
            validMessage.SetActive(true);
            Destroy(incorrect1);
            Destroy(incorrect2);
            //followMe.enabled = true;
            //StartCoroutine(moveToX(objectectA.transform, objectectB.transform.position, 3f));
            prevObject.SetActive(true);
            gameObject.GetComponent<CharacterController>();
            //characterController.enabled = true;
            answerFighter.enabled = true;
            rbody.isKinematic = true;
        }

        }

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
   

}
