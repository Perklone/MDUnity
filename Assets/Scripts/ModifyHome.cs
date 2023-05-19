using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ModifyHome : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Slider redSlider;
    [SerializeField] private Slider greenSlider;
    [SerializeField] private Slider blueSlider;
    [SerializeField] private TMP_Text indexText;

    public Renderer _houseRenderer;
    private Material[] houseMaterial;
    public Material[] altMaterial;

    public int materialIndex;
    // public GameObject House;
    void Start()
    {
        // _houseRenderer = House.GetComponent<Renderer>();
        materialIndex = 0;
        houseMaterial = _houseRenderer.materials;
        Debug.Log($"{houseMaterial[0]}, {houseMaterial[1]}");
        Color32 currentColor = houseMaterial[1].GetColor("_Color");
        Debug.Log($"{currentColor.r}, {currentColor.g}, {currentColor.b}");
        redSlider.value = (float)currentColor.r/255;
        greenSlider.value = (float)currentColor.g/255;
        blueSlider.value = (float)currentColor.b/255;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnRedValueChange(float color)
    {
        Debug.Log("Red Clicked");
        Color newColor = new Color(color, greenSlider.value, blueSlider.value);
        _houseRenderer.materials[1].SetColor("_Color",newColor);   
    }
    public void OnGreenValueChange(float color)
    {
        Debug.Log("Green Clicked");
        Color newColor = new Color(redSlider.value, color, blueSlider.value);
        _houseRenderer.materials[1].SetColor("_Color",newColor);   
    } 
    public void OnBlueValueChange(float color)
    {
        Debug.Log("Blue Clicked");
        Color newColor = new Color(redSlider.value, greenSlider.value, color);
        _houseRenderer.materials[1].SetColor("_Color",newColor);   
    }

    public void onLeftButtonClicked()
    {
        Material[] x = _houseRenderer.materials;
        Color newColor = new Color(redSlider.value, greenSlider.value, blueSlider.value);
        if (materialIndex == 0)
        {
            materialIndex = altMaterial.Length-1;
        }
        else
        {
            materialIndex--;
        }
        altMaterial[materialIndex].SetColor("_Color",newColor);
        x[1] = altMaterial[materialIndex];
        _houseRenderer.materials = x;
        indexText.text = $"{materialIndex + 1}";
    }
    
    public void onRightButtonClicked()
    {
        Material[] x = _houseRenderer.materials;
        Color newColor = new Color(redSlider.value, greenSlider.value, blueSlider.value);
        if (materialIndex == altMaterial.Length-1)
        {
            materialIndex = 0;
        }
        else
        {
            materialIndex++;
        }
        altMaterial[materialIndex].SetColor("_Color",newColor);
        x[1] = altMaterial[materialIndex];
        _houseRenderer.materials = x;
        indexText.text = $"{materialIndex + 1}";
    }
}
