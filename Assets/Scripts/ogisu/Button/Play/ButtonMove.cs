using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ButtonMove : MonoBehaviour {

    public float endValue;

    public float duration;

    public float delayTime;

	// Use this for initialization
	void Start () {
        transform.DOLocalMoveY(endValue,duration).SetDelay(delayTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
