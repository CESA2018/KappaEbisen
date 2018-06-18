using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndClimb : MonoBehaviour {

    [SerializeField]
    private GameObject ladder;

    private void OnTriggerEnter(Collider other)
    {
        ladder.transform.GetComponent<Ladder>().isClimbing = false;

    }
}
