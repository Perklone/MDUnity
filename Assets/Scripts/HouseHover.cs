using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseHover : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject popupSetting;
    
    void Start()
    {
       popupSetting.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Enter");
            popupSetting.SetActive(true);
        }
    }

    // private void OnControllerColliderHit(ControllerColliderHit hit)
    // {
    //     popupSetting.SetActive(true); 
    // }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");
        popupSetting.SetActive(false);
    }
}
