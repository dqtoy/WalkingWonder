﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PazzleWalkNode2 : MonoBehaviour
{
    [SerializeField] bool visible = true;

    void Start()
    {
        GetComponent<MeshRenderer>().enabled = visible;
    }

    // Update is called once per frame
    void Update()
    {

        CheckDist();
    }

    void CheckDist()
    {
        float dist = Vector3.Distance(PlayerScript.instance.gameObject.transform.position, this.gameObject.transform.position);
        //  print(dist);
        if (dist < 10)
        {
            transform.parent.GetComponent<PazzleNodeParent2>().ReceiveNode(this.gameObject);

        }
    }
}
