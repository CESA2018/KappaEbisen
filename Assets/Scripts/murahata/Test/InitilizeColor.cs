using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitilizeColor : MonoBehaviour {

    private enum COLOR_TYPE
    {
        white,black,yellow,blue,red
    };

    [SerializeField]
    private COLOR_TYPE color;

	// Use this for initialization
	void Start () {

        switch (color)
        {
            case COLOR_TYPE.red:
                 transform.GetComponent<Renderer>().material.color = Color.red;
                break;
            case COLOR_TYPE.yellow:
                transform.GetComponent<Renderer>().material.color = Color.yellow;
                break;
            case COLOR_TYPE.blue:
                transform.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case COLOR_TYPE.black:
                transform.GetComponent<Renderer>().material.color = Color.black;
                break;
            case COLOR_TYPE.white:
                transform.GetComponent<Renderer>().material.color = Color.white;
                break;
            default:
                transform.GetComponent<Renderer>().material.color = Color.black;
                break;
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
