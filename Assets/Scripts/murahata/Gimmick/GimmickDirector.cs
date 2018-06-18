using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//  ギミックの管理クラス
public class GimmickDirector : MonoBehaviour {

    //  ギミックの基底クラス
    private GimmickBase gimmickBase;

    public enum GIMMICK_COLOR {
        RED,
        YELLOW,
        BULE
    }


    //  この色になったときにギミックを発動する
    [SerializeField]
    private GIMMICK_COLOR gimmickColor;

    private Color color;

    //  ギミックが完了しているか
    public bool finishGimmick;

	void Start () {
        gimmickBase = transform.GetComponent<GimmickBase>();
        finishGimmick = false;
        
        switch(gimmickColor)
        {
            case GIMMICK_COLOR.RED:
                color = new Color(1, 0, 0, 1);
                break;

            case GIMMICK_COLOR.YELLOW:
                color = new Color(1, 1, 0, 1);
                break;

            case GIMMICK_COLOR.BULE:
                color = new Color(0, 0, 1, 1);
                break;
        }

    }
	
	void Update () {

        //  ギミックが完了していない
        if (finishGimmick == false)
        {
            //  オブジェクトのカラーが設定したカラーと同じ
            if (transform.GetComponent<Renderer>().material.color == color)
            {
                //  ギミックを実行する
                gimmickBase.ExecutionGimmick();
                //  ギミックの完了フラグを立てる
                finishGimmick = true;
            }
        }


	}
}
