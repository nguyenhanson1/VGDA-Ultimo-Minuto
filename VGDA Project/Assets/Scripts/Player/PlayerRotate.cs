using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{

    public float speed;
    void Update()
    {

        if (Input.GetKey("o"))
            RotateLeft();
    }

     void RotateLeft ()
    {
        transform.Rotate(Vector3.forward * -90 * speed);
    }
}
