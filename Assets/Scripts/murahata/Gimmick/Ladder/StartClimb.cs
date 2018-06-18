using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartClimb : MonoBehaviour {

    [SerializeField]
    private GameObject ladder; 
    [SerializeField]

    private void OnTriggerEnter(Collider other)
    {
        ladder.transform.GetComponent<Ladder>().isClimbing = true;

    }

}
