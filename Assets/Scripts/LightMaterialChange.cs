using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMaterialChange : MonoBehaviour
{
    public Material darkMaterial;
    public Material lightMaterial;
    // Start is called before the first frame update

    Renderer meshRenderer;

    

    private void Start()
    {
        meshRenderer = GetComponent<Renderer>();
    }

    public void TurnOn()
    {

        var materialsCopy = meshRenderer.materials;
        materialsCopy[0] = lightMaterial;
        meshRenderer.materials = materialsCopy;
    }
    public void TurnOff()
    {
        var materialsCopy = meshRenderer.materials;
        materialsCopy[0] = darkMaterial;
        meshRenderer.materials = materialsCopy;
    }
}
