using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enermyEvent : MonoBehaviour
{
    public GameObject particleEffect;
    public Rigidbody enermy;
    public AudioSource soundEffect;
    private int hitCount = 0;
    public float interpolationPeriod = 0.1f;
    public int rocketSpeed = 10;
    public GameObject rocketObject;
    public Transform rocketSpawnPoint;

    public void LaunchProjectile ()
    {
        Rigidbody b;
        b = Instantiate(rocketObject, new Vector3(rocketSpawnPoint.position.x, rocketSpawnPoint.position.y, rocketSpawnPoint.position.z), rocketSpawnPoint.rotation) as Rigidbody;
        b.AddForce(b.transform.forward * rocketSpeed);
        interpolationPeriod = 0;
    }

    public void Start()
    {
        particleEffect.SetActive(false);
        InvokeRepeating("LaunchProjectile", 2.0f, 3.0f);
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
        }
    }
}
