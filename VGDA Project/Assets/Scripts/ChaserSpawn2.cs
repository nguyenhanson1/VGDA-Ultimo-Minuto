using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaserSpawn2 : MonoBehaviour 
{
    public GameObject Chaser;
    public Transform[] spawnlocations;
    private float timeBTWspawns;
    public float startTimeBTWSpawns;

// Use this for initialization
void Start ()
    {
        timeBTWspawns = startTimeBTWSpawns;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (timeBTWspawns <= 0)
        {
            int randPos = Random.Range(0, spawnlocations.Length);
            Instantiate(Chaser, spawnlocations[randPos].position, Quaternion.identity);
            timeBTWspawns = startTimeBTWSpawns;


        } else
        {
            timeBTWspawns -= Time.deltaTime;
        }
	}
}
