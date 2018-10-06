using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncingupdate : MonoBehaviour {

    float x;

    private void Start()
    {
        x = Random.Range(-20, 30);
    }

    void SetTransformX(float newx)
    {
        transform.position = new Vector3(newx, transform.position.y, transform.position.z);
    }
    void FixedUpdate()
    {


            SetTransformX(x);

    }
}
