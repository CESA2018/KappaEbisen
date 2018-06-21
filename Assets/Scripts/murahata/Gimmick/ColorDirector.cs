using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorDirector : MonoBehaviour
{

    //  スポイト
    [SerializeField]
    private Color syringe;

    [SerializeField]
    private GameObject button;

    // Use this for initialization
    void Start()
    {
        syringe = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        ColorPicker();

        //UIの色を今取得している色に変える
        button.GetComponent<Image>().color = syringe;
    }

    //  色をつけたりスポイトでとったりする
    private void ColorPicker()
    {
        //  Rayを飛ばす
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            //  アクションボタンが押される
            if (Input.GetKeyDown(KeyCode.E))
            {
                //  スポイトの色が黒か白だったら
                if (syringe == Color.black || syringe == Color.white)
                {
                    if (hit.transform.GetComponent<Renderer>().material.color != Color.white)
                    {
                        //  オブジェクトの色を取る
                        if (hit.transform.tag == "Object")
                        {
                            syringe = hit.transform.GetComponent<Renderer>().material.color;
                            hit.transform.GetComponent<Renderer>().material.color = Color.white;
                        }
                        //  ギミックが発動前だったら色を取得できる
                        if (hit.transform.tag == "Gimmick")
                        {
                            if (hit.transform.GetComponent<GimmickDirector>().finishGimmick == false)
                            {
                                syringe = hit.transform.GetComponent<Renderer>().material.color;
                                hit.transform.GetComponent<Renderer>().material.color = Color.white;
                            }
                        }
                    }
                }
                else
                {
                    //  色が白だったら色をつけれる
                    if (hit.transform.GetComponent<Renderer>().material.color == Color.white)
                    {
                        hit.transform.GetComponent<Renderer>().material.color = syringe;
                        syringe = Color.black;
                    }
                }


            }

        }
    }

}
