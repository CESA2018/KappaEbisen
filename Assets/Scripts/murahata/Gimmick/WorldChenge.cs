﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldChenge : MonoBehaviour {

    [SerializeField]
    private GameObject m_parretWorldPos;

    [SerializeField]
    private GameObject m_player;

    [SerializeField]
    private GameObject m_normalAreaPos;

    private bool m_isParretWorld;


	// Use this for initialization
	void Start () {
        m_isParretWorld = true;

    }
	
	// Update is called once per frame
	void Update () {

        //  右クリックされたらワールドを変える
        if (Input.GetMouseButtonDown(1))
        {
            //  パレットの世界だったら
            if (m_isParretWorld)
            {
                m_player.transform.position = m_normalAreaPos.transform.position;
                m_player.transform.rotation = m_normalAreaPos.transform.rotation;
                m_isParretWorld = false;
            }
            else
            {
                m_player.transform.position = m_parretWorldPos.transform.position;
                m_player.transform.rotation = m_parretWorldPos.transform.rotation;
                m_isParretWorld = true;
            }
            
        }

        //  通常ワールド状態の座標を保存しておく
        if (m_isParretWorld == false)
        {
            m_normalAreaPos.transform.position = m_player.transform.position;
            m_normalAreaPos.transform.rotation = m_player.transform.rotation;
        }

    }

}
