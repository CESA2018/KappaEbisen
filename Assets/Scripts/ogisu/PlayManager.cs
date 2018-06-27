using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayManager : MonoBehaviour
{
    public GameObject FadePanel;

    public bool ClearFlag = false;

    public GameObject ButtonCanvas;

    public GameObject TextCanvas;

    public Scene scene;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ClearCheck();
    }

    /// <summary>
    /// クリア条件の設定とメニューを出す
    /// </summary>
    private void ClearCheck()
    {
        if (ClearFlag)
        {
            ClearMenu();

            TextCanvas.SetActive(true);
        }
    }

    /// <summary>
    /// クリアメニュー
    /// </summary>
    private void ClearMenu()
    {
        ButtonCanvas.SetActive(true);
    }
}
