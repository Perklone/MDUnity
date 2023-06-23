using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpScene : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text HeaderText;
    public String targetScene;
    void Start()
    {
        if (transform.CompareTag("Exit"))
        {
            HeaderText.text = "Exit Game";
        }
        
        else if (transform.parent.CompareTag("UrbanTropical"))
        {
            HeaderText.text = "Rumah Urban Tropical";
        }
        else if (transform.parent.CompareTag("Batik")) 
        {
            HeaderText.text = "Rumah Batik";
        } else if (transform.parent.CompareTag("Industrial"))
        {
            HeaderText.text = "Rumah Industrial";
        }
        else
        {
            HeaderText.text = "Rumah";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void JumpButtonPressed()
    {
        Debug.Log("SwitchScene Function Called");
        SceneManager.LoadScene(targetScene);
    }
}
