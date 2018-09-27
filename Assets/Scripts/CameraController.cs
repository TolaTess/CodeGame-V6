using System.Collections;
using UnityEngine;

/// <summary>
/// 1 - Follow player's X/Y  plane
/// 2 - Smooth rotations around the player in 45 degrees increment
/// </summary>

public class CameraController : MonoBehaviour {

    /// <summary>
    /// set variables for camera movement
    /// </summary>
    public Transform target;
    public Vector3 offsetPosition;
    public float moveSpeed = 5f;
    public float turnSpeed = 10f;
    public float smoothSpeed = 0.5f; //how fast camera move on 45degree angle

    Quaternion targetRotation;
    Vector3 targetPosition;
    bool smoothRotating = false;

    /// <summary>
    /// Update this instance.
    /// </summary>
    void Update()
    {
        MoveWithTarget();
        LookAtTarget();

        //left side
        if(Input.GetKeyDown(KeyCode.G) && !smoothRotating){

            StartCoroutine("RotateAroundTarget", 45);
        }
        //right side
        if (Input.GetKeyDown(KeyCode.H) && !smoothRotating)
        {
            StartCoroutine("RotateAroundTarget", -45);
        }
    }


    /// <summary>
    /// move camera to player's position + current camera offset
    /// offset is modified by RotateAroundTarget coroutine
    /// </summary>
    void MoveWithTarget()
    {
        targetPosition = target.position + offsetPosition;
        transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    }
    /// <summary>
    /// use the look vector (target + current) to aim camera toward the player
    /// </summary>
    void LookAtTarget()
    {
        targetRotation = Quaternion.LookRotation(target.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);
    }

    /// <summary>
    /// This couroutine can only have one instance running at a time
    /// determines smooth rotation of the camera
    /// </summary>
    /// <returns>The around target.</returns>
    IEnumerator RotateAroundTarget(float angle)
    {
        Vector3 vel = Vector3.zero;
        Vector3 targetOffsetPos = Quaternion.Euler(0, angle, 0) * offsetPosition;
        float distance = Vector3.Distance(offsetPosition, targetOffsetPos);
        smoothRotating = true;
        while(distance > 0.02f)
        {
            offsetPosition = Vector3.SmoothDamp(offsetPosition, targetOffsetPos, ref vel, smoothSpeed);
            distance = Vector3.Distance(offsetPosition, targetOffsetPos);
            yield return null;
        }
        //will start coroutine again
        smoothRotating = false;
        offsetPosition = targetOffsetPos;
    }

}
