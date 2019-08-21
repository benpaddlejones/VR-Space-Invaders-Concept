using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserSound : MonoBehaviour
{
    public AudioSource audioClip;
    void playLaserSound ()
    {
        audioClip.Play();
    }
}
