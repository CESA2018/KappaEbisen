using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TitleGimmick : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        transform.DOLocalPath(
            new Vector3[]
            {
                new Vector3(3f,3f),Vector3.zero,
                new Vector3(-3f,2f)
            }, 2f, PathType.CatmullRom).SetLoops(-1);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
