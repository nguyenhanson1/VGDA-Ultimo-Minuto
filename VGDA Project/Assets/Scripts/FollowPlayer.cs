using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform target;//what camerca will follow
    public Vector3 OffsetZ;
    // Update is called once per frame
    void Update () {
        transform.position = target.position + OffsetZ;
	}
}
