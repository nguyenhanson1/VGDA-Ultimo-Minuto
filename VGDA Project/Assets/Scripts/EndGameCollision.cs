using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemies")
        {
<<<<<<< HEAD
            Invoke("Restart", 2f);
=======

            Destroy(gameObject);
>>>>>>> aff687bbb9d565f35f438c0cabcaba81825fc3c4
        }


    }
}
