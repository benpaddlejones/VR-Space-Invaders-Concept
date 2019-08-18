using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockMovement : MonoBehaviour
{
    private Vector3 pos1 = new Vector3(-20, 2, 10);
    private Vector3 pos2 = new Vector3(20, 2, 10);
    public float speed;

    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong((Time.time / speed)/5, 1.0f));
    }
}
