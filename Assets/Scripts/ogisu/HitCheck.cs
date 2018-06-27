using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitCheck : MonoBehaviour {

    public GameObject ClearCanvas;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {

        Vector3 hitPos;
        foreach (ContactPoint point in collision.contacts)
        {
            hitPos = point.point;


            switch (collision.gameObject.name)
            {
                

                case "SphereFirst":
                    //Instantiate(ClearCanvas, transform.position,transform.rotation);
                    //Text text = ClearCanvas.GetComponentInChildren<Text>() as Text;
                    //ClearCanvas.GetComponent<Text>().text = "C";

                    Debug.Log("FirstHit");
                    break;
                case "SphereSecond":
                    break;
                case "SphereThird":
                    break;
                case "SphereFourth":
                    break;
                case "SphereFifth":
                    break;
            }
            //Debug.Log(hitPos);
        }
    }
}
