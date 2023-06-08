using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BatikPreset : MonoBehaviour, IPresetMenu
{
    public TMP_Text indexText;
    public Renderer _houseRenderer;
    public Renderer _leftWallRenderer;
    public Renderer _rightWallRenderer;
    public Material[] altMaterial;
    private Material[] houseMaterial;
    private Material[] leftWallMaterials;
    private Material[] rightWallMaterials;

    public int presetIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        houseMaterial = _houseRenderer.materials;
        leftWallMaterials = _leftWallRenderer.materials;
        rightWallMaterials = _rightWallRenderer.materials;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LeftButtonClicked()
    {
        Material[] tempMaterials = houseMaterial;
        Material[] tempsMaterialsLeft = leftWallMaterials;
        Material[] tempsMaterialRight = rightWallMaterials;
        if (presetIndex == 0)
        {
            presetIndex = altMaterial.Length-1;
        }
        else
        {
            presetIndex--;
        }

        tempMaterials[1] = altMaterial[presetIndex];
        tempsMaterialsLeft[0] = altMaterial[presetIndex];
        tempsMaterialRight[0] = altMaterial[presetIndex];
        _houseRenderer.materials = tempMaterials;
        _leftWallRenderer.materials = tempsMaterialsLeft;
        _rightWallRenderer.materials = tempsMaterialRight;
        UpdateIndexLabel();
    }

    public void RightButtonClicked()
    {
        Material[] tempMaterials = houseMaterial;
        Material[] tempsMaterialsLeft = leftWallMaterials;
        Material[] tempsMaterialRight = rightWallMaterials;
        if (presetIndex == altMaterial.Length-1)
        {
            presetIndex = 0;
        }
        else
        {
            presetIndex++;
        }

        tempMaterials[1] = altMaterial[presetIndex];
        tempsMaterialsLeft[0] = altMaterial[presetIndex];
        tempsMaterialRight[0] = altMaterial[presetIndex];
        _houseRenderer.materials = tempMaterials;
        _leftWallRenderer.materials = tempsMaterialsLeft;
        _rightWallRenderer.materials = tempsMaterialRight;
        UpdateIndexLabel();
    }

    public void UpdateIndexLabel()
    {
        indexText.text = $"{presetIndex + 1}";
    }
}
