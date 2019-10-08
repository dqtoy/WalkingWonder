using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleWalkNode : MonoBehaviour
{


    void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
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
        if (dist < 8)
        {
            transform.parent.GetComponent<PuzzleWalkParent>().ReceiveNode(this.gameObject);

        }
    }
}
