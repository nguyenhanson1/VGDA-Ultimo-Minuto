using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changePolarity : MonoBehaviour {
    public Material matOfObject;
    public Color newCol;
    public KeyCode changeColor;
	// Use this for initialization
	void Start () {
        matOfObject.color = Color.red;
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(changeColor))
        {
            if (matOfObject.color == Color.red)
            {
                matOfObject.color = newCol;
            }
            else
            {
                matOfObject.color = Color.red;
            }
        }
	}
}
