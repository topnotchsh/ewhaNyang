using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public static BGM instance = null;

    //public AudioClip Caketown;
    //public AudioClip ShootBGM;

    public AudioClip[] clp;

    public int num=0;

    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (instance != this)
                Destroy(this.gameObject);
        }

        //audio.clip = Caketown;
        audio.clip = clp[num];
        audio.Play();

    }

    public void mainBGM()
    {
        AudioSource audio = GetComponent<AudioSource>();
        num = 0;
        audio.clip = clp[num];
        audio.Play();
    }
    public void Shoot()
    {
        AudioSource audio = GetComponent<AudioSource>();
        num = 1;
        audio.clip = clp[num];
        audio.Play();
    }
    public void Lib()
    {
        AudioSource audio = GetComponent<AudioSource>();
        num = 2;
        audio.clip = clp[num];
        audio.Play();
    }
    public void Inven()
    {
        AudioSource audio = GetComponent<AudioSource>();
        num = 3;
        audio.clip = clp[num];
        audio.Play();
    }


}