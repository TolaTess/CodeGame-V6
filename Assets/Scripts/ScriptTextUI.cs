using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTextUI : MonoBehaviour {

    public GameObject dObject;
    public float wtime;

    void Start()
    {
        dObject.SetActive(false);
    }
    // Update is called once per frame
    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            dObject.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(wtime);
        Destroy(dObject);
        Destroy(gameObject);
    }
}
