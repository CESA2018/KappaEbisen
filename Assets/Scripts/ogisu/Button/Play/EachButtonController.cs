using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EachButtonController : BaseButtonController {

    protected override void OnClick(string objectName)
    {
        if ("RetryButton".Equals(objectName))
        {
            // RetryButtonがクリックされたとき
            this.RetryButtonClick();
        }
        else if ("NextButton".Equals(objectName))
        {
            // NextButtonがクリックされたとき
            this.NextButtonClick();
        }
        else if ("SelectButton".Equals(objectName))
        {
            // SelectButtonがクリックされたとき
            this.SelectButtonClick();
        }
        else
        {
            throw new System.Exception("Not implemented");
        }
    }

    /// <summary>
    /// RetryButton
    /// </summary>
    private void RetryButtonClick()
    {
        string sceneName = SceneManager.GetActiveScene().name;

        SceneManager.LoadScene(sceneName);

        Debug.Log("Retry");
    }

    /// <summary>
    /// SelectButton
    /// </summary>
    private void SelectButtonClick()
    {
        SceneManager.LoadScene("StageSelect");

        Debug.Log("Select");
    }

    /// <summary>
    /// NextButton
    /// </summary>
    private void NextButtonClick()
    {
        SceneManager.LoadScene("Scene/murahata/Stage1");

        Debug.Log("Next");

    }

}
