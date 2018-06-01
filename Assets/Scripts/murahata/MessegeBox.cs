using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//  画面にテキストを表示する
public class MessegeBox : MonoBehaviour {

    //  メッセージボックス
    private Text m_messegeBox;

    //  生存時間
    [SerializeField]
    private float m_lifeTime;

    //  タイマー
    private float m_timer;

	// Use this for initialization
	void Start () {
        m_messegeBox = transform.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update () {
        //  タイマーをへらす
        m_timer -= Time.deltaTime;

        //  タイマーが切れたら文字も消す
        if (m_timer <= 0)
        {
            m_messegeBox.text = "";
        }

    }

    //  テキストを表示する
    public void ShowMessege(string messege)
    {
        //  時間を設定
        m_timer = m_lifeTime;

        //  メッセージボックスにテキストを流す
        m_messegeBox.text = messege;
    }

    
}
