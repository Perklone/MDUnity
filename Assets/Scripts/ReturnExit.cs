using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnExit : MonoBehaviour
{
    // Start is called before the first frame update
    public String targetScene;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(targetScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
