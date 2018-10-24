using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TronMove : MonoBehaviour
{
    float speed; // enemy speed 
    public Vector2 min;
    // Use this for initialization
    void Start()
    {
        speed = 2f; // set speed
    }

    // Update is called once per frame
    void Update()
    {
        //Get enemy current position
        Vector2 position = transform.position;

        //Compute the new enemy position
        position = new Vector2(position.x, position.y - speed * Time.deltaTime);

        //update enemy position
        transform.position = position;

        if (position.y <= min.y)
        {
            Destroy(gameObject);
        }

    }
}