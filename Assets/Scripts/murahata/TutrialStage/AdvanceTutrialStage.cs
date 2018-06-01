using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvanceTutrialStage : MonoBehaviour {

    //  現在のステージ
    private int tutrialStage;

    //  チュートリアルの状態
    enum TUTRIALSTAGE
    {
        NON, MIRROR, WARP, GIMMICK, EBUTTON, RETURN, GORL
    }

    //  
    [SerializeField]
    private TUTRIALSTAGE stage;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        tutrialStage = TutrialMessege.GetTutrialStage();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            TutrialMessege.ChengeTutrialStage((int)stage);
        }
    }
}
