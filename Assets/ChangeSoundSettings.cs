using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSoundSettings : MonoBehaviour
{
    public AudioSource AS;

    public Slider volume, pitch, reverb;


    public void changevolume()
    {
        AS.volume = volume.value;
    }
    
    public void changepitch()
    {
        AS.pitch = pitch.value;
    }
    
    public void changereverb()
    {
        AS.reverbZoneMix = reverb.value;
    }



}
