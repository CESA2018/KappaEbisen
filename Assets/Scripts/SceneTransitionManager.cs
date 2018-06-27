using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionManager : MonoBehaviour
{
    [SerializeField]
    private string sceneName;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    static public void TransScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void TransSceneButton()
    {
        SceneManager.LoadScene(sceneName);
    }
}
