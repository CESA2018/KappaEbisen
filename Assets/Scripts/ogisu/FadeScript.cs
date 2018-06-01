using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FadeScript : MonoBehaviour
{

    public float speed = 0.01f;     //透明化の速さ
    public float alfa;              //A値を操作するための変数
    float red, green, blue;         //RGBを操作するための変数

    void Start()
    {
        //Panelの色を取得
        red = GetComponent<Image>().color.r;
        green = GetComponent<Image>().color.g;
        blue = GetComponent<Image>().color.b;
    }

    void Update()
    {
        FadeOut();
    }

    /// <summary>
    /// 明転
    /// </summary>
    public void FadeIn()
    {
        GetComponent<Image>().color = new Color(red, green, blue, alfa);

        if (alfa > 0) alfa -= speed;
    }

    /// <summary>
    /// 暗転
    /// </summary>
    public void FadeOut()
    {
        GetComponent<Image>().color = new Color(red, green, blue, alfa);
        if (alfa < 255) alfa += speed;
    }
}
