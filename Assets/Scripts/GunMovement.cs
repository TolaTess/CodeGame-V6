using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMovement : MonoBehaviour {

    public float moveAmount =1f;
    public float moveSpeed =2f;
    public GameObject gun;
    public bool onOff = false;
    public float moveOnX;
    public float moveOnY;
    public Vector3 standardPosition;
    public Vector3 newGunPosition;


	// Use this for initialization
	void Start () {

        standardPosition = transform.localPosition;
        onOff = true;
		
	}
	
	// Update is called once per frame
	void Update () {

        if (onOff == true)
        {
            moveOnX = Input.GetAxis("Mouse X") * Time.deltaTime * moveAmount;
            moveOnY = Input.GetAxis("Mouse Y") * Time.deltaTime * moveAmount;

            newGunPosition = new Vector3(standardPosition.x + moveOnX, standardPosition.y + moveOnY, standardPosition.z);
            gun.transform.localPosition = Vector3.Lerp(gun.transform.localPosition, newGunPosition, moveSpeed * Time.deltaTime);
        }
        else {
            onOff = false;
            gun.transform.localPosition = Vector3.Lerp(gun.transform.localPosition,standardPosition, moveSpeed * Time.deltaTime);
        }
	}
}
