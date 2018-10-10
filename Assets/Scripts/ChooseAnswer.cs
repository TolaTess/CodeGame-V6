using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseAnswer : MonoBehaviour {

    CharacterController characterController;
    public Transform[] targets;
    private Follow target;
    public static int score = DatabaseManager.score;
    public float speed;
    private int current;
    public float wtime;
    private StringSelectManager ssm;
    public GameObject prevObject;

	
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
        target = gameObject.GetComponent<Follow>();
        characterController = gameObject.GetComponent<CharacterController>();
    }

    IEnumerator StartFight()
    {
        //waits for seconds to give time for the change
        yield return new WaitForSeconds(wtime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            target.enabled = true;
            prevObject.SetActive(true);
            gameObject.GetComponent<CharacterController>();
            characterController.enabled = true;
        }
   
    }
}
