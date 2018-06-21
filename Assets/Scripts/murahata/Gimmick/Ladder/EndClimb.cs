using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndClimb : MonoBehaviour {

    [SerializeField]
    private GameObject ladder;
    [SerializeField]
    private GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (ladder.transform.GetComponent<Ladder>().isClimbing)
        {
            ladder.transform.GetComponent<Ladder>().isClimbing = false;
            player.transform.GetComponent<PlayerMoving>().m_isMoved = true;
        }


    }
}
