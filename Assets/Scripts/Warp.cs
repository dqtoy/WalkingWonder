using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{
    private GameObject object1 ;
    public AudioClip sound1;
    AudioSource audioSource ;

    // Start is called before the first frame update
    void Start()
    {
        object1 = GameObject.Find("back point");
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public GameObject object1 ;
    // <=Inspectorで他のオブジェクトを指定してください

    // void OnTriggerEnter(Collider theCollision)
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Back")
        {
            transform.position = object1.transform.position;
            audioSource.PlayOneShot(sound1);
        }
    }
}
