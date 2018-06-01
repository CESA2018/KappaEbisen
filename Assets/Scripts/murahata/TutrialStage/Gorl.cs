using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gorl : MonoBehaviour {

    [SerializeField]
    PlayManager playManeger;

    [SerializeField]
    GameObject gameManeger;

    [SerializeField]
    GameObject player;

    UnityChanController controller;

    MouseController mouseManager;

	// Use this for initialization
	void Start () {
        mouseManager = gameManeger.GetComponent<MouseController>();
        controller = player.GetComponent<UnityChanController>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Cursor.lockState = CursorLockMode.None;
        playManeger.ClearFlag = true;
        mouseManager.enabled = false;
        controller.enabled = false;
    }
}
