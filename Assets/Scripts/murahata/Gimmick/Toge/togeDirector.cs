using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class togeDirector : GimmickBase {

    [SerializeField]
    private GameObject[] toge;

    [SerializeField]
    private GameObject[] nockBack;

    [SerializeField]
    private GameObject[] fireEffect;

    private float alpha;

    private bool isDuring;

    private void Start()
    {
        //  不透明
        alpha = 1;

        //  実行中ではない
        isDuring = false;

        for (int i = 0; i < fireEffect.Length; i++)
        {
            fireEffect[i].gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        //  ギミックが実行中
        if (isDuring)
        {
            if (alpha > 0)
            {
                alpha -= 0.005f;
            }
            else
            {
                for (int i = 0; i < toge.Length; i++)
                {
                    toge[i].transform.gameObject.SetActive(false);
                }
                for (int i = 0; i < nockBack.Length; i++)
                {
                    nockBack[i].transform.gameObject.SetActive(false);
                }
                for (int i = 0; i < fireEffect.Length; i++)
                {
                    //fireEffect[i].gameObject.SetActive(false);
                    fireEffect[i].gameObject.GetComponent<ParticleSystem>().Stop();
                }

            }
            // 　アルファを少しずつ薄くする
            for (int i = 0; i < toge.Length; i++)
            {
                toge[i].transform.GetComponent<Renderer>().material.color = new Color(1,0,0,alpha);

                //  子供のトゲを取得する
                foreach(Transform togeChild in toge[i].gameObject.transform)
                {
                    var togeGo = togeChild.gameObject;
                    togeGo.transform.GetComponent<Renderer>().material.color = new Color(1,0,0,alpha);
                }
            }

            for (int i = 0; i < fireEffect.Length; i++)
            {
                fireEffect[i].gameObject.SetActive(true);
            }

        }
    }

    public override void ExecutionGimmick()
    {
        //  実行中フラグを立てる
        isDuring = true;
    }
}
