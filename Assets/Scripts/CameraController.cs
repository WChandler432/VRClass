﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Runs once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}