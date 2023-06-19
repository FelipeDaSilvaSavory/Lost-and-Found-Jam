using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering.PostProcessing;
using Unity.VisualScripting;



public class globalVolumeControl : MonoBehaviour
{

    private Volume volume;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float chromatic1 = (float)Variables.ActiveScene.Get("chromatic1");
    }
}
