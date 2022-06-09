using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource btnsound;

    public void OnSfx()
    {
    	btnsound.Play();
    }
}
