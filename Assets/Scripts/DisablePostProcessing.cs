using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class DisablePostProcessing : MonoBehaviour
{
    public PostProcessLayer pp;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F9) && pp.enabled == false) {
            pp.enabled = true;
        } 
        else if (Input.GetKeyDown(KeyCode.F9) && pp.enabled == true) {
            pp.enabled = false;
        }
    }

}
