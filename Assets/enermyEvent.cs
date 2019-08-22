using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enermyEvent : MonoBehaviour
{
    public GameObject particleEffect;
    public Rigidbody enermy;
    public AudioSource soundEffect;
    private int hitCount = 0;
    public int rocketSpeed = 10;
    public Rigidbody rocketObject;
    public Transform rocketSpawnPoint;


 
    private void launchProjectile ()
    {
        if (scoreManager.playGame)
        {
            Rigidbody b;
            b = Instantiate(rocketObject, new Vector3(rocketSpawnPoint.position.x, rocketSpawnPoint.position.y, rocketSpawnPoint.position.z), rocketSpawnPoint.rotation) as Rigidbody;
            b.AddForce(-b.transform.forward * rocketSpeed);
            Destroy(b, 10);
        }
    }
    



    public void Start()
    {
        particleEffect.SetActive(false);
        InvokeRepeating("launchProjectile", 2.0f, 3.0f);
    }

    public void deactivate()
    {
        hitCount++;
        soundEffect.Play();
        if (hitCount == 2) {
            particleEffect.SetActive(true);
            soundEffect.Play();
        }

        if (hitCount == 4) {
            soundEffect.Play();
            enermy.useGravity = true;
            Destroy(this, 10);
            scoreManager.points = scoreManager.points + 1;
        }
    }
}
