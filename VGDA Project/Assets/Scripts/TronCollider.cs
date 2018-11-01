using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TronCollider : MonoBehaviour {
    public int damage;
    public bool enemyColorRed;
    void OnTriggerEnter2D(Collider2D collision)
    {
        string checkString = FindObjectOfType<ChangePolarity>().Check();
        var hit = collision.gameObject;
        var health = hit.GetComponent<PlayerHealth>();
        if ((checkString == "red" & enemyColorRed == false) || (checkString == "blue" & enemyColorRed == true))
        {
            if (collision.gameObject.tag == "Player")
            {
                Debug.Log("Hit");
                if (health != null)
                {
                    health.TakeDamage(damage);
                }
            }
        }
    }
}


