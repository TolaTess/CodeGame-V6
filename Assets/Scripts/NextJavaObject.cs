using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextJavaObject : MonoBehaviour {

    public GameObject prevObject;
    public GameObject nextT;
    public GameObject nextQ;
    public float wtime;

    private JavaTarget1 Target;

    void Awake()
    {
        Target = gameObject.GetComponentInChildren<JavaTarget1>();
    }


    void Update()
    {
        if(gameObject != null)
        {
            if (prevObject == null)
            {
                    Target.enabled = true;
                    nextQ.SetActive(true);
                    nextT.SetActive(true);
                    StartCoroutine("WaitForSec");
            }
           
        } 
     
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(wtime);
        Destroy(nextQ);
        Destroy(nextT);
    }
}
