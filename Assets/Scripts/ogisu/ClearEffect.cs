using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ClearEffect : MonoBehaviour {

    public GameObject ballFirst;
    public GameObject ballSecond;
    public GameObject ballThird;
    public GameObject ballFourth;
    public GameObject ballFifth;

	// Use this for initialization
	void Start () {
        Sequence sequence = DOTween.Sequence()
            .OnStart(() =>
            {
                Debug.Log("start");
            })
            .Append(ballFirst.transform.DOMoveZ(-3f, 0.5f))
            .Append(ballSecond.transform.DOMoveZ(-3f, 0.5f))
            .Append(ballThird.transform.DOMoveZ(-3f, 0.5f))
            .Append(ballFourth.transform.DOMoveZ(-3f, 0.5f))
            .Append(ballFifth.transform.DOMoveZ(-3f, 0.5f))

            ;

        //ballFirst.transform.DOMoveZ(-3f, 1)
        //    .OnComplete(() => Destroy(ballFirst))
        //    .OnComplete(() => ballSecond.transform.DOMoveZ(-3f, 1))
        //    .OnComplete(() => Destroy(ballSecond))
        //    .OnComplete(() => ballThird.transform.DOMoveZ(-3f, 1))
        //    .OnComplete(() => Destroy(ballThird))
        //    .OnComplete(() => ballFourth.transform.DOMoveZ(-3f, 1))
        //    .OnComplete(() => Destroy(ballFourth))
        //    .OnComplete(() => ballFifth.transform.DOMoveZ(-3f, 1))
        //    .OnComplete(() => Destroy(ballFifth))
        ;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
