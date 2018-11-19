using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFighter : MonoBehaviour
{
    public Transform player;
    static Animator animator;
    string[] ClipNames = { "Hook", "Hikick" };
    string[] ClipNames1 = { "MBack", "Lkick", "Hikick" };
    string[] ClipNames2 = { "Hikick", "Lkick", "Hook" };
    public float speed = 10.0f;
    public float rotateSpeed = 100.0f;

    public Slider healthbar;

    // Use this for initialization
    void Start()
    {

        animator = GetComponent<Animator>();

    }

    void Update()
    {
        float move = Input.GetAxis("Vertical") * speed;
        float rotate = Input.GetAxis("Horizontal") * speed;

        move *= Time.deltaTime;
        rotate *= Time.deltaTime;

        transform.Translate(rotate, 0, move);

        if (healthbar.value <= 0) return;
        Vector3 direction = player.position - this.transform.position;
        float angle = Vector3.Angle(direction, this.transform.forward);
        if (Vector3.Distance(player.position, this.transform.position) < 20 && angle < 60)
        {
            direction.y = 0;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                                                       Quaternion.LookRotation(direction), 0.1f);

            animator.SetBool("Idle", false);
            if (direction.magnitude < 10)
            {
                this.transform.Translate(0, 0, 0.2f);
                //animator.SetBool("Walk", true);
            }
            int newRandom = Random.Range(0, 3);

            if (Input.GetButton("Fire1") && newRandom == 0)
            {
                foreach (string clip in ClipNames)
                {
                    animator.SetBool(clip, true);
                }
            }
            else if (Input.GetButton("Fire1") && newRandom == 1)
            {
                foreach (string clip in ClipNames1)
                {

                    animator.SetBool(clip, true);
                    Debug.Log("Sequesnce 2");
                }
            }
            else if (Input.GetButton("Fire1") && newRandom == 2)
            {
                foreach (string clip in ClipNames2)
                {

                    animator.SetBool(clip, true);
                    Debug.Log("Sequesnce 3");
                }
            }
            else
            {
                animator.SetBool("Idle", true);
            }

            if (move != 0)
            {
                animator.SetBool("Walk", true);
                animator.SetFloat("Turn", rotate);
                animator.SetBool("Idle", false);
            }

            else
            {
                animator.SetBool("Walk", false);
                animator.SetBool("Idle", true);
            }


        }
    }
}