using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
        private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("terrain"))
        {
            this.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("enemy"))
        {
            other.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }

    }
}
