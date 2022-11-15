using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using System.Collections;
using System;

public class CircularMovement : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float speed;
    [SerializeField]
    private Vector2 axis;
    private void Update()
    {
        transform.RotateAround(target.transform.position, axis, speed * Time.deltaTime);
    }
}