﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 ballmovement;

    public float speed = 5f;
    private float horizontalMovement;
    private float verticalMovement;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");

        Move(horizontalMovement, verticalMovement);
    }

    private void Move(float x, float y)
    {
        ballmovement.Set(x, y);
        ballmovement = ballmovement.normalized * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + ballmovement);
    }
}
