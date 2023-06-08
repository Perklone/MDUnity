using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IndustrialPreset : MonoBehaviour, IPresetMenu
{
    public TMP_Text indexText;
    public Renderer carportRenderer;
    public Renderer[] rosterRenderer;
    public Material[] carportMaterial;
    public Material[] rosterMaterial;
    public Texture2D carportTexture;
    private Material[] carportOldMaterial;
    private Material[] rosterOldMaterial;

    public int presetIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        //0 is Carport, 1 is Roster
        carportOldMaterial = carportRenderer.materials;
        rosterOldMaterial = rosterRenderer[0].materials;
        Debug.Log($"{rosterOldMaterial[0]}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LeftButtonClicked()
    {
        Material[] tempCarportMaterials = carportOldMaterial;
        Material[] tempRosterMaterials = rosterOldMaterial;
        if (presetIndex == 0)
        {
            presetIndex = carportMaterial.Length-1;
        }
        else
        {
            presetIndex--;
        }
        
        
        carportMaterial[presetIndex].SetTexture("_MainTex",carportTexture);
        tempCarportMaterials[0] = carportMaterial[presetIndex];
        tempRosterMaterials[0] = rosterMaterial[presetIndex];
        carportRenderer.materials = tempCarportMaterials;
        for(int i = 0; i < rosterRenderer.Length; i++) {
            rosterRenderer[i].materials = tempRosterMaterials;
        }
        UpdateIndexLabel();
    }

    public void RightButtonClicked()
    {
        Material[] tempCarportMaterials = carportOldMaterial;
        Material[] tempRosterMaterials = rosterOldMaterial;
        if (presetIndex == carportMaterial.Length-1)
        {
            presetIndex = 0;
        }
        else
        {
            presetIndex++;
        }
        carportMaterial[presetIndex].SetTexture("_MainTex",carportTexture);
        tempCarportMaterials[0] = carportMaterial[presetIndex];
        tempRosterMaterials[0] = rosterMaterial[presetIndex];
        carportRenderer.materials = tempCarportMaterials;
        for(int i = 0; i < rosterRenderer.Length; i++) {
            rosterRenderer[i].materials = tempRosterMaterials;
        }
        
        UpdateIndexLabel();
    }

    public void UpdateIndexLabel()
    {
        indexText.text = $"{presetIndex + 1}";
    }
}