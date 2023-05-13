using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModifyColor : MonoBehaviour
{
    // Start is called before the first frame update
    private Renderer _renderer;
    public GameObject House;
    private Material[] mats;
    public Slider slide;
    public GameObject g;
    void Start()
    {
        _renderer = House.GetComponent<Renderer>();
        g = GameObject.Find("Slider");
        slide = GetComponent<Slider>();
        mats = _renderer.materials;
        if (g != null)
        {
            slide = g.GetComponent<Slider>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (g != null)
        {
            Double primaryColorValue = slide.value;
            Color32 newColor = new Color32(255, (byte) (primaryColorValue*255), 0, 255); 
            // mats[2].SetColor("_Color",newColor);
            // _renderer.materials = mats; 
            _renderer.material.SetColor("_Color",newColor);
        }
        
       
    }
}
