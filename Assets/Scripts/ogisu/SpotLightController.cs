using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using System;
using DG.Tweening;

public class SpotLightController : GimmickBase {

    public GameObject flashLight;       // 点滅させるライトオブジェトを指定
    public GameObject directionalLight; // 最初はオフ
    public float minIntensity = 0;      // 最小のIntensityの値を設定
    public float maxIntensity = 30f;    // 最大のIntensityの値を設定
    private float interval;             // 点滅時間の指定
    [SerializeField]
    private bool flashFlg = false;
    [SerializeField]
    private GameObject wall;
    [SerializeField]
    private Vector3 movePos;

    void Start()
    {
        flashLight.GetComponent<Light>().intensity = 0;

        var flashStream = Observable.Interval(TimeSpan.FromSeconds(UnityEngine.Random.Range(0.01f, 0.75f))).Where(_ => flashFlg == false);

        flashStream.Subscribe(_ => FlashLight());
    }

    void Update()
    {
    }

    private void FlashLight()
    {
        interval = UnityEngine.Random.Range(1f, 10.0f);

        flashLight.GetComponent<Light>().intensity = maxIntensity;

        Observable.Timer(TimeSpan.FromSeconds(interval))
            .Subscribe(_ =>
            {
                flashLight.GetComponent<Light>().intensity = minIntensity;
            }
            );
    }

    public override void ExecutionGimmick()
    {
        flashFlg = true;

        directionalLight.GetComponent<Light>().intensity = 1;
        Debug.Log("FlashFinished");

        wall.transform.DOMove(movePos,1.0f);
    }
}
