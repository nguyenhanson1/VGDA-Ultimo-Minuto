﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameCollision : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Object Enter");
        }
    }
}