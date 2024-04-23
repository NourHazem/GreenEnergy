using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACScript : MonoBehaviour
{
    private bool status = true;
    AudioSource sound;

    private void Start()
    {
        sound = GetComponent<AudioSource>();
        
        //playsound
    }

    public void TurnOn()
    {
        status = true;
        sound.Play();
    }

    public void TurnOff()
    {
        status = false;
        sound.Stop();
    }

    public bool IsACOn()
    {
        return status;
    }
    
}
