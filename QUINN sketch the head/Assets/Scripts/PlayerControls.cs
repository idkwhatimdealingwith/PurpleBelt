﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    [Header("Rigidbody Settings")]
    [Tooltip("Rigidbody2D object that is stored")]
    public Rigidbody2D rb;

    [Tooltip("Downward speed of the object")]
    public float downSpeed = 20f;

    [Header("Movement Settings")]
    [Tooltip("Movement speed of the objects")]
    public floats movementSpeed = 10f;

    [Tooltip("Movent direction of the object")]
    public float movement = 0f;

    private SpriteRenderer spriteRenderer; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;

        spriteRenderer.flipX = movement < 0;
    }
    private void FixedUpdate() {
        Vector2 velocity = rb.velocity;

        velocity.x = movement;

        rb.velocity = velocity; 
    }
}
