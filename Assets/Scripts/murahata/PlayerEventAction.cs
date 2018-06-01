using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEventAction : MonoBehaviour {

    //  掴んでいるか
    private bool m_isGrab;

    //  掴んでいるオブジェクト
    private GameObject m_grabObject;

	// Use this for initialization
	void Start () {
        m_grabObject = null;
    }
	
	// Update is called once per frame
	void Update () {
        //  Rayを飛ばす
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            //  アクションボタンが押される
            if (Input.GetKey(KeyCode.E))
            {
                switch (hit.transform.tag)
                {
                    case "Button":
                        //  ボタンを押す
                        hit.transform.GetComponent<BaseButton>().OnButton();
                        break;
                    case "Object":
                        //  物を掴む
                        if (m_isGrab)
                        {
                            //m_isGrab = false;
                            //m_grabObject.transform.parent = null;
                        }
                        else
                        {
                            //m_isGrab = true;
                            //hit.transform.parent = transform;
                            //m_grabObject = hit.transform.gameObject;
                        }

                        break;

                    default:
                        break;
                }
            }


        }
    }
}
