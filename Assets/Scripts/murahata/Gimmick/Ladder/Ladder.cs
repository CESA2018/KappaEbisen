using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  はしご登る処理
public class Ladder : MonoBehaviour {

    [SerializeField]
    private GameObject player;
    private Rigidbody rb;
    [SerializeField]
    private float speed;

    public bool isClimbing;

    // Use this for initialization
    void Start () {
        rb = player.transform.GetComponent<Rigidbody>();
        isClimbing = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (isClimbing)
        {
            rb.useGravity = false;

            if (Input.GetKey(KeyCode.W))
            {
                Vector3 pos = rb.transform.position;
                rb.transform.position = new Vector3(pos.x, pos.y + speed, pos.z);
            }
            if (Input.GetKey(KeyCode.S))
            {
                Vector3 pos = rb.transform.position;
                rb.transform.position = new Vector3(pos.x, pos.y - speed, pos.z);
            }
        }

    }
}
