using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public GameObject PlayerBulletGO; //this is our player's bullet prefab
    public GameObject BulletPosition01;
    public GameObject BulletPosition02;

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        // fire bullets when spacebar is pressed
        if(Input.GetKeyDown("space"))
        {
            GameObject bullet01 = (GameObject)Instantiate(PlayerBulletGO);
            bullet01.transform.position = BulletPosition01.transform.position;

            // instantiate the second bullet
            GameObject bullet02 = (GameObject)Instantiate(PlayerBulletGO);
            bullet02.transform.position = BulletPosition02.transform.position;
        }
        float x = Input.GetAxisRaw("Horizontal"); // A and D key movement
        float y = Input.GetAxisRaw("Vertical"); // W and S Key movement

        //sets vector for directional input
        Vector2 direction = new Vector2(x, y).normalized;

        //function that set player position
        Move(direction);
	}

    void Move(Vector2 direction)
    {
        // find screen limits of player movement
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        max.x = max.x - 0.225f; // subtract the player sprite half width
        min.x = min.x + 0.225f;

        max.y = max.y - 0.285f;
        max.y = max.y + 0.285f;

        //get the playeer's current position
        Vector2 pos = transform.position;

        //Calculate new position
        pos += direction * speed * Time.deltaTime;

        // make sure new position is not outside the screen
        pos.x = Mathf.Clamp(pos.x, min.x, max.x);
        pos.y = Mathf.Clamp(pos.y, min.y, max.y);

        //Update player position
        transform.position = pos;
    }
}
