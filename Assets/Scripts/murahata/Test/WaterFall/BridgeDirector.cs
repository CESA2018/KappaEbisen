using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BridgeDirector : GimmickBase {

    //  移動後の座標
    [SerializeField]
    private Vector3 position;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //  ギミックを実行する
    public override void ExecutionGimmick()
    {
        transform.DOMove(position, 1.0f);
    }
}
