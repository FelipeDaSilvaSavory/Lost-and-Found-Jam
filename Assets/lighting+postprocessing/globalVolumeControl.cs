using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering.PostProcessing;
using Unity.VisualScripting;

public class globalVolumeControl : MonoBehaviour
{
    public Volume volume;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       int section = (int)Variables.ActiveScene.Get("section");


        ChromaticAberration chromaticAberration; 
        //set section 1
        if ( section == 1)
        {
           if (volume.profile.TryGet<ChromaticAberration>(out chromaticAberration))
            {
           
                chromaticAberration.intensity.value =  -75;


            }    
        }


        //set section 2
        if ( section == 2)
        {
           if (volume.profile.TryGet<ChromaticAberration>(out chromaticAberration))
            {
           
                chromaticAberration.intensity.value =  0;


            }    
        }
    }
}
