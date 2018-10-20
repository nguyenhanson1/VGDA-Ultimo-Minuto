﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameCollision : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Object Enter");
        }
    }
}
