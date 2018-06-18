using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFallDirector : GimmickBase {

    //  パーティクル
    private ParticleSystem.MainModule par;
    //  トレイル
    private ParticleSystem.TrailModule trail;
    //  水しぶき
    private ParticleSystem particle;
    //  コライダー用のオブジェクト
    [SerializeField]
    private GameObject coliderBox;

    //  影響するオブジェクト
    [SerializeField]
    private GameObject bridge;

    //  滝
    [SerializeField]
    private GameObject water;

    //  シミュレートを開始する時間
    [SerializeField]
    private float startTime;

    //  スタートが通る前の処理
    void Awake()
    {
        //  滝が流れ出したところで固定しておく
        particle = water.transform.GetComponent<ParticleSystem>();
        particle.Simulate(startTime, true, true);
    }

    // Use this for initialization
    void Start () {
        //  カラーとトレイルのオブジェクトを取得
        par = water.GetComponent<ParticleSystem>().main;
        trail = water.GetComponent<ParticleSystem>().trails;
    }
	
	// Update is called once per frame
	void Update () {

    }

    public override void ExecutionGimmick()
    {
          //  橋のギミックを実行
          bridge.GetComponent<BridgeDirector>().ExecutionGimmick();

          //  カラーを変更
          par.startColor = Color.blue;
          trail.colorOverTrail = Color.blue;
          trail.colorOverLifetime = Color.blue;

          //  パーティクルを再生
          particle.Play();

    }
}
