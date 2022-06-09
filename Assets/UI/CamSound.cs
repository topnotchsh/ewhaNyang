using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSound : MonoBehaviour
{
    public AudioSource camSound;

    public void onCamSound()
    {
    	camSound.Play();
    }
}
