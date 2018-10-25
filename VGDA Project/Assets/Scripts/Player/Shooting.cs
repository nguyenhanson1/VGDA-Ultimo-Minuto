using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour
{

    public Rigidbody2D bulletPrefab;
    public float attackSpeed = 0.5f;

    public float bulletSpeed = 500;


    // Update is called once per frame
    void Update()
    {
            if (Input.GetKey("space"))
            {
                Fire();
            }
    }

    void Fire()
    {
        //Rigidbody2D bPrefab = Instantiate(bulletPrefab,transform.position,Quaternion.identity) as Rigidbody2D;

        Rigidbody2D bPrefab = Instantiate(bulletPrefab, new Vector2(transform.position.x, transform.position.y)* bulletSpeed, Quaternion.identity) as Rigidbody2D;
 
    }
}
