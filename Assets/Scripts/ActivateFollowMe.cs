using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFollowMe : MonoBehaviour
{

    private float turn;
    private float speed;

    void Start()
    {
        turn = 0f;
        speed = 10;
    }

    void Update()
    {

        if(turn == 360)
        {
            turn = 0;
        }
        turn = turn + 70 * Time.deltaTime;
        gameObject.transform.rotation = Quaternion.Euler(0, turn, 0);
       // gameObject.transform.Translate(0, 0, speed * Time.deltaTime);

    }


    /*public GameObject ans1;
    public GameObject ans2;
    public GameObject ans3; //need to fix
    public int r;

    public float wtime;

    private Follow target1;
    private Follow target2;
    private Follow target3;
    private AnswerFighter afighter;

    // Use this for initialization
    void Start()
    {
        target1 = ans1.GetComponent<Follow>();
        target2 = ans2.GetComponent<Follow>();
        target3 = ans2.GetComponent<Follow>();
        afighter = gameObject.GetComponent<AnswerFighter>();
        //r = 0;
    }

    IEnumerator ChangeAns()
    {
        //waits for seconds to give time for the change
        yield return new WaitForSeconds(wtime);
        if (r == 0)
        {
            target1.enabled = true;
            target2.enabled = false;
            target3.enabled = false;
        }
        if (r == 1)
        {
            target2.enabled = true;
            target1.enabled = false;
            target3.enabled = false;
        }
        if (r == 2)
        {
            target3.enabled = true;
            target1.enabled = false;
            target2.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (r == 1 || r == 2)
            {
                r = 0;
            }
            else
            {
                r += 1;
            }
            StartCoroutine(ChangeAns());
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (r == 2 || r == 1)
            {
                r = 0;
            }
            else
            {
                r += 2;
            }
            StartCoroutine(ChangeAns());
        }

    } 
/*

    public GameObject objectectA;
    public GameObject objectectB;

    void Update()
    {
        StartCoroutine(moveToX(objectectA.transform, objectectB.transform.position, 3f));

    }


    bool isMoving = false;

    IEnumerator moveToX(Transform fromPosition, Vector3 toPosition, float duration)
    {
        yield return new WaitForSeconds(5f);
        //Make sure there is only one instance of this function running
        if (isMoving)
        {
            yield break; ///exit if this is still running
        }
        isMoving = true;

        float counter = 0;

        //Get the current position of the object to be moved
        Vector3 startPos = fromPosition.position;

        while (counter < duration)
        {
            counter += Time.deltaTime;
            fromPosition.position = Vector3.Lerp(startPos, toPosition, counter / duration);
            yield return null;
        }

        isMoving = false;
    }*/


}
