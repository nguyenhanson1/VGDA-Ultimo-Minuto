using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateHitBox : MonoBehaviour {
    private BoxCollider2D tronBox;
    public float Speed = 2f;
    // Update is called once per frame
    // Since offset of the BoxCollider2D is half of the size of BoxCollider2D, the change in offset value should be half of the the change in size value.
    void Update () {
        // get Component of Box collider
        tronBox = GetComponent<BoxCollider2D>();
        if (tronBox.size.y < 20.54)
        {
            // Update Offset if BoxCollider2D
            tronBox.offset = new Vector2(tronBox.offset.x, tronBox.offset.y + (0.5f * Speed) * Time.deltaTime);

            // Update Size of BoxCollider2D
            tronBox.size = new Vector2(tronBox.size.x, tronBox.size.y + Speed * Time.deltaTime);
        }
    }
}
