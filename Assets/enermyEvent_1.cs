using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enermyEvent_1 : MonoBehaviour
{
    public GameObject particleEffect;
    public Rigidbody enermy;
    public AudioSource soundEffect;
    private int hitCount = 0;
    public GameObject scoreScript;

    public void Start()
    {
        particleEffect.SetActive(false);
    }

    public void deactivate()
    {
        hitCount++;
        soundEffect.Play();
        if (hitCount == 3)
        {
            particleEffect.SetActive(true);
            soundEffect.Play();
        }

        if (hitCount == 6)
        {
            soundEffect.Play();
            enermy.useGravity = true;
            particleEffect.SetActive(true);
            Destroy(this, 10);
            scoreManager.points = scoreManager.points + 1;
        }
    }
}
