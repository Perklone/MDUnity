using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ModifyHome : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Slider redSlider;
    [SerializeField] private Slider greenSlider;
    [SerializeField] private Slider blueSlider;

    public Renderer _houseRenderer;
    private Material[] houseMaterial;
    // public GameObject House;
    void Start()
    {
        // _houseRenderer = House.GetComponent<Renderer>();
        houseMaterial = _houseRenderer.materials;
        Color32 currentColor = houseMaterial[1].GetColor("_Color");
        redSlider.value = currentColor.r;
        greenSlider.value = currentColor.g;
        blueSlider.value = currentColor.b;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnRedValueChange(float color)
    {
        Color newColor = new Color(color, greenSlider.value, blueSlider.value);
        _houseRenderer.materials[1].SetColor("_Color",newColor);   
    }
    public void OnGreenValueChange(float color)
    {
        Color newColor = new Color(redSlider.value, color, blueSlider.value);
        _houseRenderer.materials[1].SetColor("_Color",newColor);   
    } 
    public void OnBlueValueChange(float color)
    {
        Color newColor = new Color(redSlider.value, greenSlider.value, color);
        _houseRenderer.materials[1].SetColor("_Color",newColor);   
    }  
}
