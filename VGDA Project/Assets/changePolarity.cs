using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changePolarity : MonoBehaviour
{
    public Material matOfObject;
    public Color newCol;
    public KeyCode changeColor;
    private bool redSide = true;
    // Use this for initialization
    void Start()
    {
        matOfObject.color = Color.red;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(changeColor))
        {
            if (matOfObject.color == Color.red)
            {
                matOfObject.color = newCol;
                redSide = false;
            }
            else
            {
                matOfObject.color = Color.red;
                redSide = true;
            }
        }
    }
}
