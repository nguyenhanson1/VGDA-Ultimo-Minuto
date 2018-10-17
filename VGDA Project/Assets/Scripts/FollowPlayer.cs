using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform target;//what camerca will follow
    private Vector3 playerPosition;
    private float OffsetZ;
    private void Start()
    {
        playerPosition = target.position;
        OffsetZ = (transform.position - target.position).z;
    }
    // Update is called once per frame
    void Update () {
        transform.position = target.TransformVector(target.position.x,target.position.y,target.position.z + OffsetZ);
	}
}
