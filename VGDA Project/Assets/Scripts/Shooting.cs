using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject shot;
    private Transform playerpos;
    // Use this for initialization
    void Start()
    {
        playerpos = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(shot, playerpos.position, Quaternion.identity);
        }
    }
}
