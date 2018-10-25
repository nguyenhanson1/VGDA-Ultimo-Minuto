using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public bulletController bullet;
    public bool isFiring;
    public float bulletSpeed;
    public float timebtwshots;
    private float shotcounter;
    public Transform firepoint;
    private void Update()
    {
        if (isFiring)
        {
            shotcounter -= Time.deltaTime;
            if (shotcounter <= 0)
            {
                shotcounter = timebtwshots;
                bulletController newBullet = Instantiate(bullet, firepoint.position, firepoint.rotation) as bulletController;
                newBullet.speed = bulletSpeed;
            }
        }
        else
        {
            shotcounter = 0;
        }
    }
}