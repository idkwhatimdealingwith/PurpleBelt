﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision) {
        GameObject.Find("DoodleHead").SetActive(false);
        GameController.GameOver();  
    }
}
