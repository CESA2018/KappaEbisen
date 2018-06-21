using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//  ギミックベースクラス
public class GimmickBase : MonoBehaviour {

    //  ギミックを実行する
    virtual public void ExecutionGimmick()
    {
        Debug.Log("ベースを通った");
    }
}
