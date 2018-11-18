using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class JavaTarget1 : MonoBehaviour
{
    /// <summary>
    /// variables for target objects
    /// </summary>
    public float health = 20f;
    public GameObject pickupEffect;
    public static int score = 0;
    public static int stringTotal = 9;
    private BoxCollider Target;


    /// <summary>
    /// if health reduces to 0, Die method called to kill object
    /// socre is increased by 20
    /// next object is instantiated to position near prev object
    /// </summary>
  
    public void DamageToTarget(float amount)
    {


        health -= amount;
        if (health <= 0f)
        {
            Die();
            score += 20;
            //Target.enabled = true;

        }
        //DatabaseManager.score = score;
      

    }
    /// <summary>
    /// when an object dies, a particle object is instantiated to the same position
    /// Destroy is called on the object
    /// check which object type and decrement the amount to show how many left per datatype
    /// use totalcounter to end game
    /// </summary>
    void Die()
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        Destroy(gameObject);
        Debug.Log(gameObject.name);

        switch (gameObject.tag)
        {
            case "String":
            case "Fragment":
            case "Fragment2":
                stringTotal--;
                break;

        }
        Debug.Log(stringTotal);

    }

}

