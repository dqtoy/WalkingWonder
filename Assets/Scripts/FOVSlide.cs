﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOVSlide : MonoBehaviour
{
    float fovOriginal;
    float fovStep = 0;
    Camera theCamera;
    void Start()
    {
        theCamera = transform.Find("FirstPersonCharacter").GetComponent<Camera>();
        fovOriginal = theCamera.fieldOfView;
    }

    // Update is called once per frame
    void Update()
    {
        FOVcontrol();
    }
    public void BoostFOVstep()
    {
        fovStep = 1;
    }

    void FOVcontrol()
    {
        if (fovStep > 0)
        {
            theCamera.fieldOfView = Mathf.Lerp(fovOriginal, fovOriginal + 20, fovStep);
            fovStep -= Time.deltaTime;
        }
        else
        {
            theCamera.fieldOfView = fovOriginal;

        }
    }
}
