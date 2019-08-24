using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("block"))
        {
            scoreManager.blockHealthScore = scoreManager.blockHealthScore - 5;
            this.gameObject.SetActive(false);
        } else if (other.gameObject.CompareTag("MainCamera"))
        {
            scoreManager.playerHealthScore = scoreManager.playerHealthScore - 10;
            this.gameObject.SetActive(false);
        } else if (other.gameObject.CompareTag("backWall"))
        {
            this.gameObject.SetActive(false);
        }
    }
}
