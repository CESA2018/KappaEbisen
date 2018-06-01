using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//  ギミックの管理クラス
public class GimmickDirector : MonoBehaviour {

    //  ギミックの基底クラス
    private GimmickBase gimmickBase;
    
    private Vector4 YELLOW = new Vector4(1, 1, 0, 1);

    //  この色になったときにギミックを発動する
    [SerializeField]
    private Color color;

    //  ギミックが完了しているか
    public bool finishGimmick;

	void Start () {
        gimmickBase = transform.GetComponent<GimmickBase>();
        finishGimmick = false;

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
