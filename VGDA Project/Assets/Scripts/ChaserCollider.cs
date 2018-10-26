using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaserCollider : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            { 
            var hit = collision.gameObject;
            var health = hit.GetComponent<PlayerHealth>();
            if (health != null)
            {
                    health.TakeDamage(100);
                    Destroy(gameObject);
            }
    }
    }

}
