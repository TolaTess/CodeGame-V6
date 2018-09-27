using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitching : MonoBehaviour {

    public GameObject thirdPersonCamera;
    public GameObject firstPersonCamera;
    public GameObject wideRangeCamera; //need to fix
    public int cameraMode;
	
	// Update is called once per frame
	void Update () {

        if(Input.GetButtonDown("Camera"))
        {
            if(cameraMode == 1 || cameraMode == 2)
            {
                cameraMode = 0;
            }
            else
            {
                cameraMode += 1;
            }
            StartCoroutine(ChangeCamera());
        }

        if (Input.GetButtonDown("Camera1"))
        {
            if (cameraMode == 2 || cameraMode == 1)
            {
                cameraMode = 0;
            }
            else
            {
                cameraMode += 2;
            }
            StartCoroutine(ChangeCamera());
        }
		
	}

    IEnumerator ChangeCamera()
    {
        //waits for seconds to give time for the change
        yield return new WaitForSeconds(0.01f);
        if(cameraMode == 0)
        {
            thirdPersonCamera.SetActive(true);
            firstPersonCamera.SetActive(false);
            wideRangeCamera.SetActive(false);
        }
        if (cameraMode == 1)
        {
            firstPersonCamera.SetActive(true);
            thirdPersonCamera.SetActive(false);
            wideRangeCamera.SetActive(false);
        }
        if (cameraMode == 2)
        {
            wideRangeCamera.SetActive(true);
            thirdPersonCamera.SetActive(false);
            firstPersonCamera.SetActive(false);
        }
    }
}
