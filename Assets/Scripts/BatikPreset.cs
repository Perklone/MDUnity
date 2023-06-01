using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BatikPreset : MonoBehaviour, IPresetMenu
{
    public TMP_Text indexText;
    public Renderer _houseRenderer;
    public Material[] altMaterial;
    private Material[] houseMaterial;

    public int presetIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        houseMaterial = _houseRenderer.materials;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LeftButtonClicked()
    {
        Material[] tempMaterials = houseMaterial;
        if (presetIndex == 0)
        {
            presetIndex = altMaterial.Length-1;
        }
        else
        {
            presetIndex--;
        }

        tempMaterials[1] = altMaterial[presetIndex];
        _houseRenderer.materials = tempMaterials;
        UpdateIndexLabel();
    }

    public void RightButtonClicked()
    {
        Material[] tempMaterials = houseMaterial;
        if (presetIndex == altMaterial.Length-1)
        {
            presetIndex = 0;
        }
        else
        {
            presetIndex++;
        }

        tempMaterials[1] = altMaterial[presetIndex];
        _houseRenderer.materials = tempMaterials;
        UpdateIndexLabel();
    }

    public void UpdateIndexLabel()
    {
        indexText.text = $"{presetIndex + 1}";
    }
}
