using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextJavaObject : MonoBehaviour {

    public GameObject prevObject;

    private BoxCollider Target;

    private bool isDead = false;

    void Awake()
    {
        Target = gameObject.GetComponentInChildren<BoxCollider>();
    }


    void Update()
    {
        if(prevObject == null)
        {
           
                Target.enabled = true;
        }
       
    }
}
