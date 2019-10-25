using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Darkma_surv : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    //    transform.localRotation = new Vector3(-1, 1, 1);
    }

    void Update()
    {
        transform.LookAt(Camera.main.transform);
    }
}
