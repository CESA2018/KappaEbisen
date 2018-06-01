using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TutrialButton : BaseButton {

    //  壁
    [SerializeField]
    private GameObject wall_back;

    [SerializeField]
    private GameObject wall;

    //  変更後の壁の座標
    private float POSY = 6.0f;


    // Use this for initialization
    override protected void Start () {
		
	}

    // Update is called once per frame
    override protected void Update () {
		
	}


    //  ボタンが押された時に呼ぶ
    override public void OnButton()
    {
        Vector3 wallPos = wall.transform.position;
        Vector3 wallBackPos = wall.transform.position;

        wall.transform.DOMoveY(POSY,2.0f);
        wall_back.transform.DOMoveY(POSY, 2.0f);

        //wall.transform.position = new Vector3(wallPos.x, POSY, wallPos.z);
        //wall_back.transform.position = new Vector3(wallBackPos.x, POSY, wallBackPos.z);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "player")
        {
            TutrialMessege.ChengeTutrialStage(4);
        }
    }

}
