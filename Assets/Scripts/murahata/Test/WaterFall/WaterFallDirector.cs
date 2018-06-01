using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WaterFallDirector : MonoBehaviour {

    //  パーティクル
    private ParticleSystem.MainModule par;
    //  トレイル
    private ParticleSystem.TrailModule trail;

    ParticleSystem particle;

    //  影響するオブジェクト
    [SerializeField]
    private GameObject gameObject;

    //  シミュレートを開始する時間
    [SerializeField]
    private float startTime;

    //  スタートが通る前の処理
    void Awake()
    {
        particle = transform.GetComponent<ParticleSystem>();
        particle.Simulate(startTime, true, true);
    }

    // Use this for initialization
    void Start () {
        par = GetComponent<ParticleSystem>().main;
        trail = GetComponent<ParticleSystem>().trails;
    }
	
	// Update is called once per frame
	void Update () {
       //par.startColor = Color.red;
       //trail.colorOverTrail = Color.red;
       //trail.colorOverLifetime = Color.red;
    }
}
