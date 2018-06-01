using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorWorldPosition : MonoBehaviour {

    //  プレイヤーの座標
    [SerializeField]
    private GameObject m_player;

    //  ズレ分の座標
    [SerializeField]
    private float shiftLengh;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(m_player.transform.position.x - shiftLengh, m_player.transform.position.y, m_player.transform.position.z);
    }
}
