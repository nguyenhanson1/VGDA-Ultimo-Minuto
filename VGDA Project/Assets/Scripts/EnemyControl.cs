using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    float speed; // enemy speed

	// Use this for initialization
	void Start ()
    {
        speed = 2f; // set speed
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Get enemy current position
        Vector2 position = transform.position;

        //Compute the new enemy position
        position = new Vector2(position.x, position.y - speed * Time.deltaTime);

        //update enemy position
        transform.position = position;

        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));


	}
}
