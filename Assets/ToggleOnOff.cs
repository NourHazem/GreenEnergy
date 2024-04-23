using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleOnOff : MonoBehaviour
{
    public LightMaterialChange lightObject;
    public void Toggle()
    {
        if (lightObject is not null)
        {
            if (gameObject.activeSelf)
            {
                lightObject.TurnOff();
            }
            else
            {
                lightObject.TurnOn();
            }
        }
        gameObject.SetActive(!gameObject.activeSelf);
        
    }
}