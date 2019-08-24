using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enermyMove : MonoBehaviour
{
    public Vector3 pos1 = new Vector3(16, -1, 8);
    public Vector3 pos2 = new Vector3(-16, -1, 8);
    public float speed;

    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong((Time.time / speed) / 5, 1.0f));
    }
}
