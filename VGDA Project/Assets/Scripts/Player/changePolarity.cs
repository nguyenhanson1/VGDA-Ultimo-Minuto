using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePolarity : MonoBehaviour
{
    public Material matOfObject;
    public Color newCol;
    public KeyCode changeColor;
    private bool redSide = true;
    private string playerColor;
    // Use this for initialization
    void Start()
    {
        matOfObject.color = Color.red;
    }
    // Update is called once per frame

    public string Check()
    {
        if (matOfObject.color == Color.red)
        {
            playerColor = "red";
        }
        else
        {
            playerColor = "blue";
        }
        return playerColor;
    }
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
