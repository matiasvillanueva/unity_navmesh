using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float lerpSpeed = 1.0f;

    private Vector3 offset;

    private Vector3 targetPos;

    private GameObject entryPoint;

    private void Awake () {
        entryPoint = GameObject.FindGameObjectWithTag("EntryPoint");   
        transform.position = new Vector3(entryPoint.transform.position.x, entryPoint.transform.position.y, transform.position.z);
    }
    private void Start()
    {
        if (target == null) return;
        offset = transform.position - target.position;        
    }

    private void Update()
    {
        if (target == null) return;

        targetPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetPos, lerpSpeed * Time.deltaTime);
    }

}

