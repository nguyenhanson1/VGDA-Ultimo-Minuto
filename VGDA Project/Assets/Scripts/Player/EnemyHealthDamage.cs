using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthDamage : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        var hit = collision.gameObject;
        var health = hit.GetComponent<PlayerHealth>();
        if (health != null)
        {
            health.TakeDamage(10);
            Debug.Log("Oops");
        }

        Destroy(gameObject);
    }
}
