﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enermyMove : MonoBehaviour
{
    private Vector3 pos1 = new Vector3(25, -1, 10);
    private Vector3 pos2 = new Vector3(-25, -1, 10);
    public float speed;

    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong((Time.time / speed) / 5, 1.0f));
    }
}
