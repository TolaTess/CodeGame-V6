using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class JavaTarget : MonoBehaviour
{
    /// <summary>
    /// variables for target objects
    /// </summary>
    public float health = 20f;
    public GameObject pickupEffect;
    //public static int score = DatabaseManager.score;
    public static int score = 100;
    public static int stringTotal = 9;
    public static int integerTotal = 9;
    public static int booleanTotal = 9;
    public static int totalCounter = 0;
    public GameObject nextObject;

    float x;
    float y;
    float z;
    Vector3 pos;
    void Start()
    {
        x = Random.Range(-7, 3);
        z = 0;
        y = Random.Range(3, 5);
        pos = new Vector3(x, y, z);
    }

    /// <summary>
    /// call gameover if all objects killed
    /// </summary>
    private void Update()
    {
        if (totalCounter == 3)
        {
            FindObjectOfType<GameManager>().GameOver();
            stringTotal = 9;
            booleanTotal = 9;
            integerTotal = 9;

        }
    }
    /// <summary>
    /// if health reduces to 0, Die method called to kill object
    /// socre is increased by 20
    /// next object is instantiated to position near prev object
    /// </summary>
    /// <param name="amount">Amount.</param>
    public void DamageToTarget(float amount)
    {


                health -= amount;
                if (health <= 0f)
                 {
                Die();
                score += 20;
            Instantiate(nextObject, transform.position + pos, transform.rotation);
                     
               }
                DatabaseManager.score = score;
         
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

        switch(gameObject.tag)
        {
            case "String":
                stringTotal--;
                totalCounter++;
                break;
            case "Integer":
                integerTotal--;
                totalCounter++;
                break;
            case "Boolean":
                booleanTotal--;
                totalCounter++;
                break;
            
        }
        Debug.Log(totalCounter);

    }

}

