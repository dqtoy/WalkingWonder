using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glasses : MonoBehaviour
{
    GameObject teleportSpot;
    GameObject theGlasses;
    Vector3 glassesInPlace;
    void Start()
    {
        foreach (Transform child in transform)
        {
            if (child.name.Contains("glass"))
                theGlasses = child.gameObject;
            if (child.name.Contains("tele"))
                teleportSpot = child.gameObject;
        }

        glassesInPlace = theGlasses.transform.position;
        theGlasses.transform.position = new Vector3(99999, 99999, 9999);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float dist = Vector3.Distance(PlayerScript.instance.gameObject.transform.position, transform.position);
            if (dist < 10)
            {
                if(Vector3.Distance(theGlasses.transform.position, glassesInPlace) > 100){
                    theGlasses.transform.position = glassesInPlace;
                    PlayerScript.instance.gameObject.GetComponent<CharacterController>().enabled = false;
                    StartCoroutine(PlacePlayer(2.5f));
               
                }
            }
        }
    }
    IEnumerator PlacePlayer(float waitTime)
    {
        float elapsedTime = 0f; while (elapsedTime / waitTime < 1f) { elapsedTime += Time.deltaTime; yield return null; } //if (MenuAndPause.gamePlayState == 1) 

        PlayerScript.instance.gameObject.transform.position = teleportSpot.transform.position + new Vector3(0, 3, 0);
        theGlasses.transform.position = new Vector3(99999, 99999, 9999);
        PlayerScript.instance.gameObject.GetComponent<CharacterController>().enabled = true;
    }
}
