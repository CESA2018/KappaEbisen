using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFallColiderDirector : GimmickBase {

    [SerializeField]
    private GameObject river;

    [SerializeField]
    private GameObject bridge;

    [SerializeField]
    private Particle particle;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void ExecutionGimmick()
    {
        // todo
        //  滝パーティクルの実行(Play on awake)

        //  滝パーティクルの色を変更
        //  橋のギミックを実行
        //  川の色を変える
    }
}
