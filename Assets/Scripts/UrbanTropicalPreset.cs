using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UrbanTropicalPreset : MonoBehaviour, IPresetMenu
{
    public TMP_Text indexText;
    public Renderer _leftRoofRenderer;
    public Renderer _rightRoofRenderer;
    public Renderer _leftWallRenderer;
    public Renderer _rightWallRenderer;
    public Renderer _blockRenderer;
    // public Renderer[] _rosterRenderer;
    
    public Material[] roofMaterials;
    public Material[] wallMaterials;
    public Material[] blockMaterials;
    // public Material[] rosterMaterials;

    private Material[] oldRoofMaterials;
    private Material[] oldWallMaterials;
    private Material[] oldBlockMaterials;
    // private Material[] oldRosterMaterials;


    public int presetIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        oldRoofMaterials = _leftRoofRenderer.materials;
        oldWallMaterials = _leftWallRenderer.materials;
        oldBlockMaterials = _blockRenderer.materials;
        // oldRosterMaterials = _rosterRenderer[0].materials;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LeftButtonClicked()
    {
        Material[] tempRoofMaterials = oldRoofMaterials;
        Material[] tempWallMaterials = oldWallMaterials;
        Material[] tempBlockMaterials = oldBlockMaterials;
        // Material[] tempRosterMaterials = oldRosterMaterials;

        if(presetIndex == 0) {
            presetIndex = roofMaterials.Length-1;
        }
        else {
            presetIndex--;
        }
        tempRoofMaterials[0] = roofMaterials[presetIndex];
        tempWallMaterials[0] = wallMaterials[presetIndex];
        tempBlockMaterials[1] = blockMaterials[presetIndex];
        // tempRosterMaterials[0] = rosterMaterials[presetIndex];

        _leftRoofRenderer.materials = tempRoofMaterials;
        _rightRoofRenderer.materials = tempRoofMaterials;
        _leftWallRenderer.materials = tempWallMaterials;
        _rightWallRenderer.materials = tempWallMaterials;
        _blockRenderer.materials = tempBlockMaterials;
        //TODO: For-loop
        // .materials = tempRoofMaterials;
        
        
        UpdateIndexLabel();
    }

    public void RightButtonClicked()
    {
        Material[] tempRoofMaterials = oldRoofMaterials;
        Material[] tempWallMaterials = oldWallMaterials;
        Material[] tempBlockMaterials = oldBlockMaterials;
         // Material[] tempRosterMaterials = oldRosterMaterials;

        if(presetIndex == roofMaterials.Length-1) {
            presetIndex = 0;
        }
        else {
            presetIndex++;
        }
        tempRoofMaterials[0] = roofMaterials[presetIndex];
        tempWallMaterials[0] = wallMaterials[presetIndex];
        tempBlockMaterials[1] = blockMaterials[presetIndex];
        // tempRosterMaterials[0] = rosterMaterials[presetIndex];

        _leftRoofRenderer.materials = tempRoofMaterials;
        _rightRoofRenderer.materials = tempRoofMaterials;
        _leftWallRenderer.materials = tempWallMaterials;
        _rightWallRenderer.materials = tempWallMaterials;
       
        _blockRenderer.materials = tempBlockMaterials;
        UpdateIndexLabel();
    }

    public void UpdateIndexLabel()
    {
        indexText.text = $"{presetIndex + 1}";
    }
}
