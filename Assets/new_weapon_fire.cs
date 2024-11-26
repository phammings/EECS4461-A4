using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class new_weapon_fire : MonoBehaviour
{

    public float delayvalue,Refiredelay;
    public AudioSource WeaponAudio;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("playaudio", delayvalue, Refiredelay);
    }

    // Update is called once per frame
    void playaudio()
    {
        WeaponAudio.Play();
    }


    public void Update()
    {
        float distance = Vector3.Distance(player.transform.position, WeaponAudio.transform.position);
        Debug.LogError("Diatance is " + distance);

        //if (distance > 5)
        //{
        //    WeaponAudio.volume = 0;
        //}
        //else
        //{
        //    // Adjust volume based on proximity
        //    if(distance>1&& distance < 10) 
        //    WeaponAudio.volume = /*1 -*/ (distance / 10);
        //    else if (distance > 10)
        //        WeaponAudio.volume = /*1 -*/ (distance / 100);
        //    else
        //        WeaponAudio.volume = /*1 -*/ (distance / 1);
        //}
    }



}

