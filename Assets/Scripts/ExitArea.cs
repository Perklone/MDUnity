using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitArea : MonoBehaviour
{
    // Start is called before the first frame update
    public String targetScene;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchSceneButtonPressed()
    {
        Debug.Log("SwitchScene Function Called");
        SceneManager.LoadScene(targetScene);
    }
}
