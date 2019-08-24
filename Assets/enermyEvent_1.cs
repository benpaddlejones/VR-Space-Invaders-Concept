using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enermyEvent_1 : MonoBehaviour
{
    public GameObject particleEffect;
    public Rigidbody enermy;
    public AudioSource soundEffect;
    private int hitCount = 0;
    public int rocketSpeed = 750;
    public Rigidbody rocketObject;
    public Transform rocketSpawnPoint;
    private float randomNumber;

    private void launchProjectile()
    {
        if (scoreManager.activeGame)
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
        randomNumber = Random.Range(1.8f, 4.0f);
        InvokeRepeating("launchProjectile", 1.25f, randomNumber);
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
            scoreManager.points++;
        }
    }
}
