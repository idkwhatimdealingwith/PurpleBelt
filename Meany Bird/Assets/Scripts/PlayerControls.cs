﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [Header("Game controller Object for controlling the game")]
    public GameController gameController;
    [Header("Velocity")]
    public float velocity = 5;
    private Rigidbody2D rb;
    private float objectHeight; 
    // Start is called before the first frame update
    void Start()
    {
        gameController = GetComponent<GameController>();
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2; 
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetMouseButtonDown(0)) 
            {
            rb.velocity = Vector2.up * velocity; 
        }
    }
}
