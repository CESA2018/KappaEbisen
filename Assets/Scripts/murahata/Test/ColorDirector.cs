using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorDirector : MonoBehaviour
{

    //  スポイト
    [SerializeField]
    private Color syringe;

    // Use this for initialization
    void Start()
    {
        syringe = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        ColorPicker();
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
                if (syringe == Color.black || syringe == Color.white)
                {
                    //  オブジェクトの色を取る
                    syringe = hit.transform.GetComponent<Renderer>().material.color;
                    hit.transform.GetComponent<Renderer>().material.color = Color.white;
                }
                else // 色をつける
                {
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
