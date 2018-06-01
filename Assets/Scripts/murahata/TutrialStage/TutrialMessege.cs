using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TutrialMessege : MonoBehaviour {

    //  メッセージボックス
    [SerializeField]
    private GameObject messegeBoxObject;

    private MessegeBox messegeBox;

    //  チュートリアルフラグ
    static private int flagNum;

    enum TUTRIALSTAGE
    {
        NON,MIRROR,WARP,GIMMICK,EBUTTON,RETURN,GORL
    }

    // Use this for initialization
    void Start () {
        //  メッセージボックスの初期化
        messegeBox = messegeBoxObject.GetComponent<MessegeBox>();
        flagNum = (int)TUTRIALSTAGE.MIRROR;
    }

    // Update is called once per frame
    void Update () {
        Messege();
    }

    private void Messege()
    {
        switch(flagNum)
        {
            case (int)TUTRIALSTAGE.NON:
                break;
            case (int)TUTRIALSTAGE.MIRROR:
                messegeBox.ShowMessege("右クリックで鏡を設置する");
                if (Input.GetMouseButton(1)) flagNum = (int)TUTRIALSTAGE.WARP;
                break;
            case (int)TUTRIALSTAGE.WARP:
                messegeBox.ShowMessege("左クリックで鏡の中にワープする");
                if (Input.GetMouseButton(0)) flagNum = (int)TUTRIALSTAGE.GIMMICK;
                break;
            case (int)TUTRIALSTAGE.GIMMICK:
                messegeBox.ShowMessege("ギミックを探す");
                break;
            case (int)TUTRIALSTAGE.EBUTTON:
                messegeBox.ShowMessege("Eボタンでスイッチを押す");
                break;
            case (int)TUTRIALSTAGE.RETURN:
                messegeBox.ShowMessege("元のステージに戻る");
                break;
            case (int)TUTRIALSTAGE.GORL:
                messegeBox.ShowMessege("ゴールに入る");
                break;
            default:
                break;
        }
    }

    //  フラグの状態を変更する
    static public void ChengeTutrialStage(int n)
    {
        flagNum = n;
    }

    //  フラグの状態を返す
    static public int GetTutrialStage()
    {
        return flagNum;
    }

}
