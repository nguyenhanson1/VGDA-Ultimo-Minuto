using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform target;//what camerca will follow
    private Vector3 playerPosition;
    private Vector3 OffsetZ;
    private void Start()
    {
        playerPosition = target.position;
        OffsetZ = new Vector3(0,0,transform.position.z - target.position.z);
    }
    // Update is called once per frame
    void Update () {
        transform.position = target.position + OffsetZ;
	}
}
