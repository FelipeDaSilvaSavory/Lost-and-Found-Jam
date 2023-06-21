using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
//using UnityEngine.Rendering.PostProcessing;
using Unity.VisualScripting;



public class globalVolumeControl : MonoBehaviour
{

    public Volume volume;

    private ChromaticAberration chromaticAberration;
    private Vignette vignette;
    private FilmGrain filmGrain;

    // Start is called before the first frame update
   
   
    void Start()
    {
        //volume = GetComponent<Volume>();
        //volume.profile.GetSetting(out chromaticAberration);

        //volume.profile.TryGet<ChromaticAberration>(out chromaticAberration);

        volume.profile.TryGet(out chromaticAberration);
        volume.profile.TryGet(out vignette);
        volume.profile.TryGet(out filmGrain);
    }



    // Update is called once per frame
    void Update()
    {
        //ChromaticAberration chromaticAberration;

        float chromatic1 = (float)Variables.ActiveScene.Get("chromatic1");
        chromaticAberration.intensity.value = chromatic1;


        float vignette1 = (float)Variables.ActiveScene.Get("vignette1");
        vignette.intensity.value = vignette1;

        float filmGrain1 = (float)Variables.ActiveScene.Get("filmGrain1");
        filmGrain.intensity.value = filmGrain1;

        //if (volume.profile.TryGet<ChromaticAberration>(out chromaticAberration))
       
    }
}
